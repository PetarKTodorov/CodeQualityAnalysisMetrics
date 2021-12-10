namespace P05.CyclomaticComplexity
{
    public class ProblemCode
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
                if (string.IsNullOrWhiteSpace(user.Username))
                {
                    // Check is Username is unique
                }

                if (string.IsNullOrWhiteSpace(user.Password) && string.IsNullOrWhiteSpace(user.ConfirmPassword))
                {
                    // Check is Password and ConfirmPassword are equals
                }

                if (user.Age < 18)
                {
                    // Cancel registration
                }

                if (string.IsNullOrWhiteSpace(user.Email))
                {
                    // Check Valid Email  
                }

                if (string.IsNullOrWhiteSpace(user.Phone))
                {
                    // Validate phone
                }
            }
        }
    }
}
