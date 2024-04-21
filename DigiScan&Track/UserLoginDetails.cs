

namespace DigiScan_Track
{
    public class UserLoginDetails
    {
        //This page is used to ensure when the user logs in their details are stored and used for history tracking and gaining access to certain pages

        private static UserLoginDetails instance;

        //Getters and setters for every instance to allow the program to set the values on any form
        public string Username { get; set; }
        public bool loggedIN { get; set; }
        public string Permission {  get; set; }

        private UserLoginDetails() { }

        public static UserLoginDetails Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserLoginDetails();
                }
                return instance;
            }
        }
    }
}
