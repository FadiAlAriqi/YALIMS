using System.Data;
using Newtonsoft.Json;

namespace YALIMS.Model
{
    public class Admin : IPerson
    {
        protected override string[,] Fields()
        {
            return new string[,] {
                    { "ID", ID.ToString() },
                    { "email", Email },
                    { "username", Username},
                    { "password", Password},
                    { "phone", PhoneNumber.ToString() },
                    { "id",ID.ToString() }
                };
        }
        
        public Admin()
        {
            TYPE = "Admin";
        }
    }
}
