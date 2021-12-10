namespace P03.ShotgunSurgery
{
    using System;

    public class ProblemCode
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

            public void PostStatus(string newStatus)
            {
                if (!this.User.IsLogged()) 
                {
                    throw new InvalidOperationException("User is not logged");
                }

                // some logic 
            }

            public void UploadProfilePicture(Picture newPicture)
            {
                if (!this.User.IsLogged()) {
                    throw new InvalidOperationException("User is not logged");
                }

                // some logic
            }

            public void SendMessage(User recipient, Message messageSend)
            {
                if (!this.User.IsLogged()) {
                    throw new InvalidOperationException("User is not logged");
                }

                // some logic
            }
        }
    }
}
