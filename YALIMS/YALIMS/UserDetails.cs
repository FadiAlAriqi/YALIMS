using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YALIMS
{
    internal static class UserDetails
    {
        public static Int64 ID;
        public static string username;
        public static string role;

        //private static int num;

        public static int CourseTypeNumber(string course)
        {
            string coursestring = course;
            int num = 0;


            if (coursestring == "Level Course")
            {
                num = 1;
                return num;
            }

            if (coursestring == "Writing Course")
            {
                num = 2;
                return num;
            }

            if (coursestring == "Listening Course")
            {
                num = 3;
                return num;
            }

            return num;



        }

        internal static void AuthorizeUser(string password, DataTable userdata, Form form, Form newWindow)
        {
            if (userdata.Rows[0].Field<Int64>("Status") == 0)
            {
                MessageBox.Show("User couldn't be found");
                return;
            }
            if (userdata.Rows[0].Field<string>("password") == password)
            {
                UserDetails.ID = userdata.Rows[0].Field<Int64>("ID");
                UserDetails.username = userdata.Rows[0].Field<string>("Username");
                UserDetails.role = "Admin";
                form.Hide();
                newWindow.ShowDialog();
                form.Close();
            }
            else
            {
                MessageBox.Show("Password or username are wrong!", "Warning!");
            }
        }

        public static string CourseTypeString(int number)
        {
            string course="";
            if (number == 1)
            {
                course = "Level Course";
                return course;
            }

            if (number == 2)
            {
                course = "Writing Course";
                return course;
            }

            if (number == 3)
            {
                course = "Listening Course";
                return course;
            }

            return course;

        }

        public static string CourseTimeString(string time)
        {
            switch (time)
            {
                case "8:30 - 10:30": return "08:30:00";
                case "10:30 - 12:30": return "10:30:00";
                case "12:30 - 2:30": return "12:30:00";
                case "2:30 - 4:30": return "14:30:00";
                case "4:30 - 6:30": return "16:30:00";
                default: return "";
            }
        }

        public static string CourseStringTime(string time)
        {
            switch (time)
            {
                case "08:30:00": return "8:30 - 10:30";
                case "10:30:00": return "10:30 - 12:30";
                case "12:30:00": return "12:30 - 2:30";
                case "14:30:00": return "2:30 - 4:30";
                case "16:30:00": return "4:30 - 6:30";
                default: return "";
            }
        }
    }
}
