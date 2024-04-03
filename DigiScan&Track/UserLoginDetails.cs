

namespace DigiScan_Track
{
    public class UserLoginDetails
    {

        private static UserLoginDetails instance;

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
