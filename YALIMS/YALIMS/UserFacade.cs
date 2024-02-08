using System.Data;
using YALIMS.Model;

namespace YALIMS
{
    internal class UserFacade
    {
        public static void ActivateAdmin(string username)
        {
            try
            {
                Admin.TYPE = "Admin";
                Admin.Activate(username);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void DeleteAdmin(int ID)
        {
            try
            {
                Admin.TYPE = "Admin";
                Admin.Remove(ID.ToString(), "ID");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static DataTable? StudentMarks()
        {
            Mark.TYPE = "Mark";
            try
            {
                return Mark.Find(UserDetails.ID.ToString(), "Student_ID");
            }
            catch
            {
                return new DataTable();
            }
        }

        public static bool AddAdmin(string username, string password, string phoneNumber, string email)
        {
            Admin newadmin = new Admin();
            try
            {
                newadmin.Username = username;
                newadmin.Password = password;
                newadmin.PhoneNumber = Int32.Parse(phoneNumber);
                newadmin.Email = email;
                return newadmin.Save() switch
                {
                    "1" => true,
                    _ => false,
                };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            //FOR TESTING
            //MessageBox.Show(newadmin.Save());
        }

        public static void UpdateAdmin(int ID, string username, string password, string email, string phoneNumber)
        {
            Admin newadmin = new Admin();
            try
            {
                newadmin.ID = ID;
                newadmin.Username = username;
                newadmin.Password = password;
                newadmin.Email = email;
                newadmin.PhoneNumber = Int32.Parse(phoneNumber);
                newadmin.Update();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            // FOR TESTING
            //MessageBox.Show(newadmin.Update());
        }

        public static bool AddTeacher(string name, string username, string password, string email, string phoneNumber, string salary)
        {
            Teacher teacher = new Teacher();
            try
            {
                teacher.Name = name;
                teacher.Username = username;
                teacher.Password = password;
                teacher.Email = email;
                teacher.PhoneNumber = Int32.Parse(phoneNumber);
                teacher.Salary = Int32.Parse(salary);
                return teacher.Save() switch
                {
                    "1" => true,
                    _ => false,
                };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            // FOR TESTING
            //MessageBox.Show(teacher.Save());
        }

        public static bool AddStudent(string name, string username, string password, string email, string phoneNumber, string level, string time, string course, DateTime birthdate)
        {
            Student newStudent = new Student();
            try
            {
                newStudent.Name = name;
                newStudent.Username = username;
                newStudent.Password = password;
                newStudent.Email = email;
                newStudent.PhoneNumber = Int32.Parse(phoneNumber);
                newStudent.Level = Int32.Parse(level);
                newStudent.Time = UserDetails.CourseTimeString(time);
                newStudent.Course = UserDetails.CourseTypeNumber(course);
                newStudent.BirthDate = birthdate;
                return newStudent.Save() switch
                {
                    "1" => true,
                    _ => false,
                };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            //FOR TESTING
            //MessageBox.Show(newStudent.Save());
        }

        public static void UpdateTeacher(int ID, string name, string username, string password, string email, string salary, string phoneNumber)
        {
            Teacher updteacher = new Teacher();
            try
            {
                updteacher.ID = ID;
                updteacher.Name = name;
                updteacher.Username = username;
                updteacher.Password = password;
                updteacher.Email = email;
                updteacher.Salary = Int32.Parse(salary);
                updteacher.PhoneNumber = Int32.Parse(phoneNumber);
                updteacher.Update();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //FOR TESTING
            //MessageBox.Show(updteacher.Update());
        }

        public static DataTable? AllAdmins()
        {
            try
            {
                Admin.TYPE = "Admin";
                return Admin.All();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new DataTable();
            }
        }

        public static void AddMark(string course, string level, string studentID, string grade)
        {
            Mark mark = new Mark();
            try
            {
                mark.Course = UserDetails.CourseTypeNumber(course);
                mark.Level = Int32.Parse(level);
                mark.Student = Int32.Parse(studentID);
                mark.Grade = Int32.Parse(grade);
                mark.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            // FOR TESTING
            // MessageBox.Show(mark.Save());
        }

        public static void DeleteTeacher(string username)
        {
            try
            {
                Teacher.TYPE = "Teacher";
                Teacher.Remove(username);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void ActivateTeacher(string username)
        {
            try
            {
                Teacher.TYPE = "Teacher";
                Teacher.Activate(username);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void UpdateStudent(int ID, string name, string username, string password, string email, string level, string phoneNumber, string time, DateTime birthdate, string course)
        {
            Student updstudent = new Student();
            try
            {
                updstudent.ID = ID;
                updstudent.Name = name;
                updstudent.Username = username;
                updstudent.Password = password;
                updstudent.Email = email;
                updstudent.Level = Int32.Parse(level);
                updstudent.PhoneNumber = Int32.Parse(phoneNumber);
                updstudent.Time = UserDetails.CourseTimeString(time);
                updstudent.BirthDate = birthdate;
                updstudent.Course = UserDetails.CourseTypeNumber(course);
                updstudent.Update();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //FOR TESTING
            //MessageBox.Show(updstudent.Update());
        }

        public static void DeleteStudent(string username)
        {
            try
            {
                Student.TYPE = "Student";
                Student.Remove(username);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void ActivateStudent(string username)
        {
            try
            {
                Student.TYPE = "Student";
                Student.Activate(username);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static DataTable? AllTeachers()
        {
            try
            {
                Teacher.TYPE = "Teacher";
                return Teacher.All();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new DataTable();
            }
        }

        public static void UpdateMark(string course, string level, string grade, string studentID)
        {
            Mark upmark = new Mark();
            try
            {
                upmark.Course = UserDetails.CourseTypeNumber(course);
                upmark.Level = Int32.Parse(level);
                upmark.Grade = Int32.Parse(grade);
                Mark.Update(new string[,]
                {
               { "MarkID", studentID},
               { "CourseLevel", upmark.Level.ToString()},
               { "CourseName", upmark.Course.ToString()},
               { "Mark", upmark.Grade.ToString()}
                });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //FOR TESTING
            /*MessageBox.Show(Mark.Update(new string[,]
            {
               { "MarkID", studentID},
               { "CourseLevel", upmark.Level.ToString()},
               { "CourseName", upmark.Course.ToString()},
               { "Mark", upmark.Grade.ToString()}
            }));*/
        }

        public static void DeleteMark(string ID)
        {
            try
            {
                Mark.TYPE = "Mark";
                Mark.Remove(ID, "ID");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static DataTable? AllStudents()
        {
            try
            {
                Student.TYPE = "Student";
                return UserDetails.role == "Teacher" ? Student.Find(UserDetails.ID.ToString(), "teacher") : Student.All();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new DataTable();
            }
        }

        public static DataTable? AllMarks()
        {
            try
            {
                Mark.TYPE = "Mark";
                return UserDetails.role == "Teacher" ? Mark.Find(UserDetails.ID.ToString(), "teacher") : Mark.All();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new DataTable();
            }
        }

        public static DataTable? LoginStudent(string username)
        {
            Student student = new Student();
            try
            {
                student.Username = username;
                return Student.Find(student.Username);
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return new DataTable();
            }
        }

        public static DataTable? LoginAdmin(string username)
        {
            Admin admin = new Admin();
            try
            {
                admin.Username = username;
                return Admin.Find(admin.Username);
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return new DataTable();
            }
        }

        public static DataTable? LoginTeacher(string username)
        {
            Teacher teacher = new Teacher();
            try
            {
                teacher.Username = username;
                return Teacher.Find(teacher.Username);
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return new DataTable();
            }
        }

    }
}
