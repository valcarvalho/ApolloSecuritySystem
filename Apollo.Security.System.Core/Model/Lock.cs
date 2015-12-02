using System.Collections.Generic;

namespace Apollo.Security.System.Core.Model
{
    public class Lock
    {
        private readonly int _roomNumber;
        private readonly int _id;

        public Lock(int id, int roomNumber)
        {
            _roomNumber = roomNumber;
            _id = id;
        }

        public int LockId
        {
            get { return _id; }
        }

        public int RoomNumber
        {
            get { return _roomNumber; }
        }

        public virtual List<Member> Members { get; set; }
    }
}
