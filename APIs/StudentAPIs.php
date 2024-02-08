<?php

if(isset($_POST))
{ 
    require_once 'Conn.php';
    


    //SelectStudent
    if($_POST['RequestType'] == "select")
    {
        $username = "";
        $teacher = "";
        if(isset($_POST["username"]))
            $username = $_POST['username'];
        if(isset($_POST["teacher"]))
            $teacher = $_POST['teacher'];
        $Students = array();
        
        if ($username != "")
        {
            $statment = "SELECT Id AS ID, Name, Email, Phone AS PhoneNumber, Birthdate AS BirthDate, Username, Password, CourseType AS Course, Level, Time, Status FROM student_inf WHERE Username = '$username'";
        }
        else if ($teacher != "")
        {
            $statment = "SELECT Id AS ID, Name, Email, Phone AS PhoneNumber, Birthdate AS BirthDate, Username, Password, CourseType AS Course, Level, Time, Status FROM student_inf WHERE teacher = $teacher";
        }
        else
        {
            $statment = "SELECT Id AS ID, Name, Email, Phone AS PhoneNumber, Birthdate AS BirthDate, Username, Password, CourseType AS Course, Level, Time, Status FROM student_inf ";
        }
        $base = $conn->prepare($statment);
        $base -> execute();
        $data = $base -> fetch(PDO::FETCH_ASSOC);

        if ($data>0)
        {
            while($data)
            {
                $Students[] = $data;
                $data = $base->fetch(PDO::FETCH_ASSOC);
            }
            echo json_encode($Students);
        }

        else
        {
            echo "ERR";;
        }
    
    }


#######################################################################################################################


     //updateStudent
    if($_POST['RequestType'] == "insert")
    {

        $name = htmlspecialchars($_POST['name']);
        $username = htmlspecialchars($_POST['username']);
        $password = htmlspecialchars($_POST['password']);
        $email = filter_var($_POST['email'] , FILTER_SANITIZE_EMAIL);
        $tel = filter_var($_POST['phone'] , FILTER_SANITIZE_NUMBER_INT);
        $birthdate = htmlspecialchars($_POST['birthdate']);
        $coursetype = htmlspecialchars($_POST['coursetype']);
        $time = htmlspecialchars($_POST['time']);
        $level = htmlspecialchars($_POST['level']);
        /*$filename = $_FILES["img"]["name"];
        $tempname = $_FILES["img"]["tmp_name"];
        $folder = "imgs/".$filename;*/


        $bugs = [];



        if(empty($name))
        {
            $bugs[]="Please enter the name ";
        }
        elseif(strlen($name) > 50)
        {
            $bugs[]=" please the name should be less  ";
        }




        
        if(empty($email))
        {
            $bugs[]="Please email is required ";
        }
        elseif(filter_var($email , FILTER_SANITIZE_EMAIL) == false )
        {
            $bugs[]="Email is wrong ";
        }

        $stm = "SELECT Email FROM student_inf WHERE Email = '$email' ";
        $base = $conn->prepare($stm);
        $base -> execute();
        $data = $base -> fetch(PDO::FETCH_ASSOC);

        if($data)
        {
            $bugs[] = "Email is already exist ";
        }





        if(empty($password))
        {
            $bugs[]="Please enter the password ";
        }
        elseif(strlen($password) < 6)
        {
            $bugs[]="The password must be more than 6 characters ";
        }





        if(empty($tel))
        {
            $bugs[]="Please enter the phone number ";
        }
        elseif(strlen($tel)!=9)
        {
            $bugs[]="The phone number must be 9 digits ";
        }
        elseif($tel < 700000000 || $tel > 779999999 )
        {
            $bugs[]="Please enter a vaild phone number ";
        }





        if(empty($birthdate))
        {
            $bugs[]="Please enter the birthdate ";
        }





        if(empty($username))
        {
            $bugs[]="Please enter the usernaem ";
        }
        

        $statement = "SELECT Username FROM student_inf WHERE Username = '$username' ";
        $base = $conn->prepare($statement);
        $base -> execute();
        $data = $base -> fetch(PDO::FETCH_ASSOC);

        if($data)
        {
            $bugs[] = "Username is already exist ";
        }




        if($coursetype !=1 && $coursetype!=2 && $coursetype!=3)
        {
            $bugs[]="Wrong course type was sent, please try agian ";
        }





        if($time != '08:30:00' && $time != '10:30:00' && $time != '12:30:00' && $time != '14:30:00' && $time != '16:30:00')
        {
            $bugs[]="Wrong time was sent, please try agian";
        }


            
        if(empty($bugs))
        {
            $statement = "INSERT INTO student_inf (Email, Phone, Username, Password, Name, Birthdate, CourseType, Level, Time)
            VALUES ('$email', $tel, '$username', '$password', '$name',  '$birthdate',  $coursetype,  $level, '$time')";
            $update_sql = $conn->prepare($statement)->execute();
            
            if (!$update_sql)
            {
                echo "ERR";;
            }
            else
            {
                echo "1"; 
            }
        }
        else
        {
            echo "ERR";; 
        }

    
    
    }

    

#######################################################################################################################

if($_POST['RequestType'] == "activate")
    {
        $username = htmlspecialchars($_POST['username']);
        $bugs = [];
    

        if(empty($username))
        {
            $bugs[]="Please enter the usernaem ";
        }
    
        $statement = "SELECT Username, Status FROM student_inf WHERE Username = '$username' ";
        $base = $conn->prepare($statement);
        $base -> execute();
        $data = $base -> fetch(PDO::FETCH_ASSOC);

        if(!$data)
        {
            $bugs[] = "Username doesn't exist ";
        }
        if($data['Status'] == "1") $status = 0;
        else $status = 1;

        if(empty($bugs))
        {

            $statement = "UPDATE student_inf SET Status = $status WHERE Username = '$username'";
            $update_sql = $conn->prepare($statement)->execute();
            if (!$update_sql)
            {
                echo "ERR";;
            }
            else
            {
                echo "1"; 
            }
        }
        else
        {
            echo "ERR";; 
        }
    }


#######################################################################################################################
    //updateStudent
    if($_POST['RequestType'] == "update")
    {

        $ID = $_POST['ID'];
        $name = htmlspecialchars($_POST['name']);
        $username = htmlspecialchars($_POST['username']);
        $password = htmlspecialchars($_POST['password']);
        $email = filter_var($_POST['email'] , FILTER_SANITIZE_EMAIL);
        $tel = filter_var($_POST['phone'] , FILTER_SANITIZE_NUMBER_INT);
        $date = htmlspecialchars($_POST['birthdate']);
        $coursetype = htmlspecialchars($_POST['coursetype']);
        $time = htmlspecialchars($_POST['time']);
        $Level = htmlspecialchars($_POST['level']);
        //$filename = $_FILES["img"]["name"];
        //$tempname = $_FILES["img"]["tmp_name"];
        //$folder = "imgs/".$filename;


        $bugs = [];
 

        //if(empty($ID))
       // {
      //  $bugs[]="Please enter the Id "; #---------------------------------------------------------
       // }


        if(empty($name))
        {
            $bugs[]="Please enter the name ";
        }
        elseif(strlen($name) > 50)
        {
            $bugs[]=" please the name should be less  ";
        }

        if(empty($email))
        {
            $bugs[]="Please email is required ";
        }
        elseif(filter_var($email , FILTER_SANITIZE_EMAIL) == false )
        {
            $bugs[]="Email is wrong ";
        }

        $stm = "SELECT Email FROM student_inf WHERE Email = '$email' AND ID != $ID";
        $base = $conn->prepare($stm);
        $base -> execute();
        $data = $base -> fetch(PDO::FETCH_ASSOC);

        if($data)
        {
            $bugs[] = "Email is already exist ";
        }

        if(empty($password))
        {
            $bugs[]="Please enter the password ";
        }
        elseif(strlen($password) < 6)
        {
            $bugs[]="The password must be more than 6 characters ";
        }

        if(empty($tel))
        {
            $bugs[]="Please enter the phone number ";
        }
        elseif(strlen($tel)!=9)
        {
            $bugs[]="The phone number must be 9 digits ";
        }
        elseif($tel < 700000000 || $tel > 779999999 )
        {
            $bugs[]="Please enter a vaild phone number ";
        }

        if(empty($date))
        {
            $bugs[]="Please enter the birthdate ";
        }

        if(empty($username))
        {
            $bugs[]="Please enter the usernaem ";
        }
        

        $statement = "SELECT Username FROM student_inf WHERE Username = '$username' AND ID != $ID";
        $base = $conn->prepare($statement);
        $base -> execute();
        $data = $base -> fetch(PDO::FETCH_ASSOC);

        if($data)
        {
            $bugs[] = "Username is already exist ";
        }




        if($coursetype !=1 && $coursetype!=2 && $coursetype!=3)
        {
            $bugs[]="Wrong course type was sent, please try agian ";
        }





        if($time != '08:30:00' && $time != '10:30:00' && $time != '12:30:00' && $time != '14:30:00' && $time != '16:30:00')
        {
            $bugs[]="Wrong time was sent, please try agian";
        }


            
        if(empty($bugs))
        {
            if(isset($_POST['username']))
            {
                $statement = "UPDATE student_inf SET Name = '$name',  Email = '$email', Phone = '$tel', Birthdate = '$date', Username = '$username', CourseType = '$coursetype', Level = $Level, Time = '$time'";
                if($password != ""){
                    $statement .= ", Password = '$password'";
                }
                $statement .= " WHERE ID = '$ID' ";
            }
            $update_sql = $conn->prepare($statement)->execute();
            echo $statement;
            if (!$update_sql)
            {
                echo "ERR";
            }
            else
            {
                echo "1"; 
            }
        }
        else
        {
            echo "ERR";; 
        }

    
    
    }


#######################################################################################################################


    //DeleteStudent
    if($_POST['RequestType'] == "delete")
    {
        $username = $_POST['username'];

        $statement = " DELETE FROM student_inf WHERE Username = '$username' ";
        $delete_sql = $conn->prepare($statement)->execute();

        if (!$delete_sql)
        {
            echo "ERR";;
        }
        else
        {
            echo "1"; 
        }
    }




}

else 
{
    echo "ERR";;
}

?>