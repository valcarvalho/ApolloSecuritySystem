using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Apollo.Security.System.Core.DataLayer;
using Apollo.Security.System.Core.Interface;

[assembly: InternalsVisibleTo("Apollo.Security.System.Core.Tests")]
namespace Apollo.Security.System.Core
{
    public class LockController
    {
        private readonly ISystemCoreRepository _repository;
        private readonly IConsoleOutputWrapper _consoleOutputWrapper;
        private readonly ITime _time;

        public LockController(ISystemCoreRepository repository, IConsoleOutputWrapper consoleOutputWrapper, ITime time)
        {
            if(repository == null) throw new ArgumentNullException("repository");
            if (consoleOutputWrapper == null) throw new ArgumentNullException("repository");
            if (time == null) throw new ArgumentNullException("repository");
            _repository = repository;
            _consoleOutputWrapper = consoleOutputWrapper;
            _time = time;
        }

        public void UnlockDoor(int roomNumber, int keyCardNumber)
        {
            if (ValidateEmployee(roomNumber, keyCardNumber))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                _consoleOutputWrapper.WriteToConsole("Green led on");
                _consoleOutputWrapper.WriteToConsole("Door UnLocked");
                _repository.WriteLog(DateTime.Now, roomNumber, keyCardNumber);
                _time.Delay(5000);
                LockDoor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                _consoleOutputWrapper.WriteToConsole("Red led on");
                _time.Delay(5000);
                _consoleOutputWrapper.WriteToConsole("Red led off");
                Console.ResetColor();
            }
        }

        private void LockDoor()
        {
            _consoleOutputWrapper.WriteToConsole("Door lock");
            _consoleOutputWrapper.WriteToConsole("Green led off");
            Console.ResetColor();
        }

        internal bool ValidateEmployee(int roomNumber, int keyCardNumber)
        {
            var doorLock = _repository.GetLockByRoomNumber(roomNumber);
            if (doorLock == null) throw new Exception("Invalid room number, cannot find lock that is link to room number");
            var validMember = doorLock.Members.FirstOrDefault(member => member.CardKeyNumber == keyCardNumber);
            return validMember != null;
        }
    }
}
