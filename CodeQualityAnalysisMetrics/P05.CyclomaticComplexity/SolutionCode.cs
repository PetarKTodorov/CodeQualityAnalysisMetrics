namespace P05.CyclomaticComplexity
{
    public class SolutionCode
    {
        public class User
        {
            public string Username { get; set; }

            public string Email { get; set; }

            public string Phone { get; set; }

            public int Age { get; set; }

            public string Password { get; set; }

            public string ConfirmPassword { get; set; }

        }

        public void RegisterUser(User user)
        {
            if (user != null)
            {
                IsUserUnique(user);

                IsPasswordsMatch(user);

                IsAdult(user);

                IsEmailValid(user);

                IsPhoneValid(user);
            }
        }

        private static void IsPhoneValid(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Phone))
            {
                // Validate phone
            }
        }

        private static void IsEmailValid(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Email))
            {
                // Check Valid Email  
            }
        }

        private static void IsAdult(User user)
        {
            if (user.Age < 18)
            {
                // Cancel registration
            }
        }

        private static void IsPasswordsMatch(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Password) && string.IsNullOrWhiteSpace(user.ConfirmPassword))
            {
                // Check is Password and ConfirmPassword are equals
            }
        }

        private static void IsUserUnique(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username))
            {
                // Check is Username is unique
            }
        }
    }
}
