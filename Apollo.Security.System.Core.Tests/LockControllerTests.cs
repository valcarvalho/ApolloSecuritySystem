using System;
using System.Collections.Generic;
using Apollo.Security.System.Core.DataLayer;
using Apollo.Security.System.Core.Interface;
using Apollo.Security.System.Core.Model;
using Moq;
using NUnit.Framework;

namespace Apollo.Security.System.Core.Tests
{
    [TestFixture]
    public class LockControllerTests
    {
        private Mock<ISystemCoreRepository> _mockRepository;
        private Mock<ITime> _mockTime;
        private Mock<IConsoleOutputWrapper> _mockConsoleOutput;

        [SetUp]
        public void SetUp()
        {
            _mockRepository = new Mock<ISystemCoreRepository>();
            _mockTime = new Mock<ITime>();
            _mockConsoleOutput = new Mock<IConsoleOutputWrapper>();
        }

        [Test]
        public void LockController_UnLockDoor_ShouldUnlockDoorForOnlyFiveSecondsIfKeyCardIsValid()
        {
            //Arange
            _mockRepository.Setup(m => m.GetLockByRoomNumber(It.IsAny<int>())).Returns(GetTestMembers());
            var lockController = new LockController(_mockRepository.Object, _mockConsoleOutput.Object, _mockTime.Object);

            //Act
            lockController.UnlockDoor(101, 802);

            //Assert
            _mockTime.Verify(m => m.Delay(It.Is<int>(time => time == 5000)), Times.Once);
            _mockConsoleOutput.Verify(m => m.WriteToConsole(It.Is<string>(str => str == "Door UnLocked")), Times.Once);   
        }

        [Test]
        public void LockController_UnLockDoor_ShouldIlluminateGreenLedForFiveSeconds_ThenTurnOff_IfKeyCardIsValid()
        {
            //Arange
            _mockRepository.Setup(m => m.GetLockByRoomNumber(It.IsAny<int>())).Returns(GetTestMembers());
            var lockController = new LockController(_mockRepository.Object, _mockConsoleOutput.Object, _mockTime.Object);

            //Act
            lockController.UnlockDoor(101, 802);

            //Assert
            _mockConsoleOutput.Verify(m => m.WriteToConsole(It.Is<string>(str => str == "Green led on")), Times.Once);
            _mockTime.Verify(m => m.Delay(It.Is<int>(time => time == 5000)), Times.Once);
            _mockConsoleOutput.Verify(m => m.WriteToConsole(It.Is<string>(str => str == "Green led off")), Times.Once);
        }

        [Test]
        public void LockController_ValidateEmployee_ShouldReturnTrueIfEmployeeKeyCardNumberIsValid()
        {
            //Arange
            _mockRepository.Setup(m => m.GetLockByRoomNumber(It.IsAny<int>())).Returns(GetTestMembers());
            var lockController = new LockController(_mockRepository.Object, _mockConsoleOutput.Object, _mockTime.Object);

            //Act
            var actualResult = lockController.ValidateEmployee(101, 802);

            //Assert
            Assert.True(actualResult);
            
        }

        [Test]
        public void LockController_ValidateEmployee_ShouldReturnFalseIfEmployeeKeyCardNumberIsInValid()
        {
            //Arange
            _mockRepository.Setup(m => m.GetLockByRoomNumber(It.IsAny<int>())).Returns(GetTestMembers());
            var lockController = new LockController(_mockRepository.Object, _mockConsoleOutput.Object, _mockTime.Object);

            //Act
            var actualResult = lockController.ValidateEmployee(101, 123);

            //Assert
            Assert.False(actualResult);
        }


        [Test]
        public void LockController_UnLockDoor_ShouldNotUnlockDoorIfKeyCardIsInValid()
        {
            //Arange
            _mockRepository.Setup(m => m.GetLockByRoomNumber(It.IsAny<int>())).Returns(GetTestMembers());
            var lockController = new LockController(_mockRepository.Object, _mockConsoleOutput.Object, _mockTime.Object);

            //Act
            lockController.UnlockDoor(101, 345);

            //Assert
            _mockConsoleOutput.Verify(m => m.WriteToConsole(It.Is<string>(str => str == "Door UnLocked")), Times.Never);
        }

        [Test]
        public void LockController_UnLockDoor_IlluminateRedLedForFiveSeconds_ThenTurnOff_IfKeyCardIsInValid()
        {
            //Arange
            _mockRepository.Setup(m => m.GetLockByRoomNumber(It.IsAny<int>())).Returns(GetTestMembers());
            var lockController = new LockController(_mockRepository.Object, _mockConsoleOutput.Object, _mockTime.Object);

            //Act
            lockController.UnlockDoor(101, 345);

            //Assert
            _mockConsoleOutput.Verify(m => m.WriteToConsole(It.Is<string>(str => str == "Red led on")), Times.Once);
            _mockTime.Verify(m => m.Delay(It.Is<int>(time => time == 5000)), Times.Once);
            _mockConsoleOutput.Verify(m => m.WriteToConsole(It.Is<string>(str => str == "Red led off")), Times.Once);

        }

        [Test]
        public void LockController_UnLockDoor_CreateLogWhenDoorIsUnlocked()
        {
            //Arange
            _mockRepository.Setup(m => m.GetLockByRoomNumber(It.IsAny<int>())).Returns(GetTestMembers());
            var lockController = new LockController(_mockRepository.Object, _mockConsoleOutput.Object, _mockTime.Object);

            //Act
            lockController.UnlockDoor(101, 801);

            //Assert
            _mockConsoleOutput.Verify(m => m.WriteToConsole(It.Is<string>(str => str == "Door UnLocked")), Times.Once);
           _mockRepository.Verify(m=>m.WriteLog(It.IsAny<DateTime>(), It.Is<int>(rm=>rm == 101), It.Is<int>(key=> key == 801)));
        }


        private Lock GetTestMembers()
        {
            return new Lock(234, 101)
            {
                Members = new List<Member>
                {
                    new Member(801, true),
                    new Member(802, false),
                    new Member(803, false),
                    new Member(804, false)
                }
            };
        }
    }
}
