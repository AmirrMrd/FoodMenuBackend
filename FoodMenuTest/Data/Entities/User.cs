namespace FoodMenuTest.Data.Entities
{
    public class User
    {
        #region properties

        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailOrMobile { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }


        #endregion
    }
}
