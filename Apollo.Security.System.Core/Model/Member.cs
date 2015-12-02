namespace Apollo.Security.System.Core.Model
{
    public class Member
    {
        private readonly int _cardKeyNumber;
        private readonly bool _isAdmin;

        public Member(int cardKeyNumber, bool isAdmin)
        {
            _cardKeyNumber = cardKeyNumber;
            _isAdmin = isAdmin;
        }

        public int LockId { get; set; }

        public bool IsAdmin
        {
            get { return _isAdmin; }
        }

        public int CardKeyNumber
        {
            get { return _cardKeyNumber; }
        }
    }
}
