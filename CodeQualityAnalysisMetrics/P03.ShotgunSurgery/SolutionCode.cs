namespace P03.ShotgunSurgery
{
    using System;

    public class SolutionCode
    {
        public class User
        {
            public bool IsLogged()
            {
                // some logic

                return true;
            }
        }

        public class Picture
        {

        }

        public class Message
        {

        }

        public class SocialNetwork
        {
            public User User { get; set; }

            public void AssertUserIsLogged()
            {
                if (!this.User.IsLogged()) 
                {
                    throw new InvalidOperationException("User is not logged");
                }
            }

            public void PostStatus(string newStatus)
            {
                this.AssertUserIsLogged();

                // some logic 
            }

            public void UploadProfilePicture(Picture newPicture)
            {
                this.AssertUserIsLogged();

                // some logic
            }

            public void SendMessage(User recipient, Message messageSend)
            {
                this.AssertUserIsLogged();

                // some logic
            }
        }
    }
}
