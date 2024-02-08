using System.Data;
using Newtonsoft.Json;

namespace YALIMS.Model
{
    public class Teacher : IPerson
    {
        /// <summary>
        /// Teacher salary
        /// </summary>
        public int Salary;
        protected override string[,] Fields()
        {
            return new string[,] {
                    { "ID", ID.ToString() },
                    { "name", Name },
                    { "email", Email },
                    { "username", Username},
                    { "password", Password},
                    { "mobile", PhoneNumber.ToString() },
                    { "salary", Salary.ToString() }
                };
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public Teacher() : base()
        {
            this.Salary = 0;
            TYPE = "Teacher";
        }
        /// <summary>
        /// Unset all properties.
        /// </summary>
        public override void Unset()
        {
            this.Name = "";
            this.Username = "";
            this.Password = "";
            this.PhoneNumber = 0;
            this.Email = "";
            this.Salary = 0;
        }
    }
}
