namespace Messaging.Domain
{
    public struct UserId
    {
        private readonly string _userId;

        public UserId(string userId)
        {
            _userId = userId;
        }
    }
}