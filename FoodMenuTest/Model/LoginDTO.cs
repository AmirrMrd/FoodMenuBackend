namespace FoodMenuTest.Model
{
    public class LoginDTO
    {
        public string emailOrMobile { get; set; }
        public string password { get; set; }
    }

    public enum LoginResult
    {
        error,
        success,
        UserNotFound
    }
}
