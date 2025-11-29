namespace EventEase.Services
{
    public class UserSessionService
    {
        public string CurrentUser { get; private set; } = string.Empty;
        public bool IsLoggedIn => !string.IsNullOrEmpty(CurrentUser);

        public void Login(string userName)
        {
            CurrentUser = userName;
        }

        public void Logout()
        {
            CurrentUser = string.Empty;
        }
    }
}