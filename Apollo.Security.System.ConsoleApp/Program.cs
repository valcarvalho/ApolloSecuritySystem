using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Apollo.Security.System.Core;
using Apollo.Security.System.Core.DataLayer;

namespace Apollo.Security.System.ConsoleApp
{
    class Program
    {
        private static List<int> _roomNumbers =new List<int>(); 
        static void Main(string[] args)
        {

            var repository = new SystemCoreRepository();
            var lockController = new LockController(repository, new ConsoleOutputWrapper(), new Time());
            Console.WriteLine(@"Press Esc to exit the program");
            Console.WriteLine(@"Available Room Numbers:");
            _roomNumbers.AddRange(repository.GetAllLocks().Select(loc=>loc.RoomNumber));
            foreach (var roomNumber in _roomNumbers)
            {
                Console.WriteLine(@"Room number {0}", roomNumber);
            }

            while (true)
            {
                int keyNumber;
                int roomNumber;
                Console.WriteLine(@"Enter room number to unlock door");
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.Escape)
                    break;
                
                var inputRoomNumber = key + Console.ReadLine();
                if (InputValidation(inputRoomNumber, out roomNumber)) continue;
                if (!IsRoomNumberInputInDatabase(roomNumber))
                {
                    Console.WriteLine(@"Invalid room number: Enter room number from above list");
                    continue;
                } 
                Console.WriteLine(@"Enter cardkey number");
                if (InputValidation(Console.ReadLine(), out keyNumber)) continue;  
                lockController.UnlockDoor(roomNumber, keyNumber);
                Console.WriteLine("\n");
            }
        }

        private static bool IsRoomNumberInputInDatabase(int roomNumber)
        {
            return _roomNumbers.Contains(roomNumber);
        }

        private static bool InputValidation(string input, out int outputValue)
        {
            if (!int.TryParse(Regex.Replace(input, @"[^\d]", ""), out outputValue))
            {
                Console.WriteLine("Invalid input should be number\n");
                return true;
            }
            return false;
        }
    }
}
