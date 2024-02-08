using System.Text.RegularExpressions;
using YALIMS.Controller;

namespace YALIMS.Model
{
    public abstract class IPerson : Database
    {
        /// <summary>
        /// Patterns to validate user inputs
        /// </summary>
        private readonly Regex usernamePattern = new(@"^[_a-zA-Z]\w+[_a-zA-Z0-9]");
        private readonly Regex namePattern = new(@"[A-Za-z\s]+$");
        private readonly Regex phoneNumberPattern = new(@"[0-9]{1,9}");
        private readonly Regex emailPattern = new(@"^[\w-\.]+@[\w]+(\.+[\w]{2,}){1,}");
        
        private string name;
        /// <summary>
        /// Person Name
        /// </summary>
        private int status;
        public int Status {
            get
            {
                return status;
            }
            set
            {
                if(value == 0 || value == 1)
                {
                    this.status = value;
                } else
                {
                    throw new Exception("Status should be 1 or 0");
                }
            }
        }
        public int ID;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length <= 50 && namePattern.Match(value).ToString() == value)
                {
                    this.name = value;
                }
                else
                {
                    throw new Exception("Name should not be more than 50 characters");
                }
            }
        }
        private string username;
        /// <summary>
        /// Person Username
        /// </summary>
        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                if (usernamePattern.Match(value).ToString() == value)
                {
                    this.username = value;
                }
                else
                {
                    throw new Exception("please enter a valid username");
                }
            }
        }
        private string password;
        /// <summary>
        /// Person Password
        /// </summary>
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }
        private int phoneNumber;
        /// <summary>
        /// Person Phone Number
        /// </summary>
        public int PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                if (value > 700000000 && value < 779999999 && phoneNumberPattern.Match(value.ToString()).ToString() == value.ToString())
                {
                    this.phoneNumber = value;
                }
                else
                {
                    throw new Exception("please enter a valid phone number");
                }
            }
        }
        private string email;
        /// <summary>
        /// Person Email
        /// </summary>
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (emailPattern.Match(value).ToString() == value)
                {
                    this.email = value;
                } else
                {
                    throw new Exception("please enter a valid email address");
                }
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public IPerson()
        {
            this.Name = "";
            this.Username = "";
            this.Password = "";
            this.PhoneNumber = 777777777;
            this.Email = "";
            
        }
        /// <summary>
        /// Unset all class variables
        /// </summary>
        public virtual void Unset()
        {

        }
    }
}
