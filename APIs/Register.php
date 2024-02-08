<?php

if(isset($_POST))
{ 
    require_once 'Conn.php';
    $name = htmlspecialchars($_POST['name']);
    $password = htmlspecialchars($_POST['password']);
    $email = filter_var($_POST['email'] , FILTER_SANITIZE_EMAIL);
    $tel = filter_var($_POST['phone'] , FILTER_SANITIZE_NUMBER_INT);
    $date = htmlspecialchars($_POST['birthdate']);
    $username = htmlspecialchars($_POST['username']);
    $coursetype = htmlspecialchars($_POST['coursetype']);
    $time = htmlspecialchars($_POST['time']);
    $filename = $_FILES["img"]["name"];
    $tempname = $_FILES["img"]["tmp_name"];
    $folder = "imgs/".$filename;

    $bugs = [];

            if(empty($name))
            {
                $bugs[]="Please enter your name ";
            }
            elseif(strlen($name) > 50)
            {
                $bugs[]=" please the name should be less  ";
            }


             


             if(empty($email))
             {
                 $bugs[]="Please enter your email ";
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
                 $bugs[] = "Email is already used ";
             }


             
             

            if(empty($password))
            {
                $bugs[]="Please enter your password ";
            }
            elseif(strlen($password) < 6)
            {
                $bugs[]="The password must be more than 6 characters ";
            }





            if(empty($tel))
            {
                $bugs[]="Please enter your phone number ";
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
                $bugs[]="Please enter your birthdate ";
            }





            if(empty($username))
            {
                $bugs[]="Please enter your usernaem ";
            }

            $stm = "SELECT Username FROM student_inf WHERE Username	 = '$username' ";
            $base = $conn->prepare($stm);
            $base -> execute();
            $data = $base -> fetch(PDO::FETCH_ASSOC);

            if($data)
            {
                $bugs[] = "Username is already used ";
            }





            if($coursetype !=1 && $coursetype!=2 && $coursetype!=3)
            {
                $bugs[]="Wrong course type was sent, please try agian ";
            }





            if($time != '8:30' && $time != '10:30' && $time != '12:30' && $time != '2:30' && $time != '4:30')
            {
                $bugs[]="Wrong time was sent, please try agian ";
            }


            
		
		    if (!move_uploaded_file($tempname, $folder)) 
                {
                    $bugs[]= "Failed to upload image";
                }
           



    
             if(empty($bugs))
             {

                $encryptedPassword = Crypt(md5($password), sha1($password));
                $statement = "INSERT INTO student_inf (Name, Email, Phone, Birthdate, Username, Password, CourseType, Time, img)
                              VALUES ('$name', '$email', $tel, '$date', '$username', '$encryptedPassword', $coursetype, '$time', '$filename')";
                $sql = $conn->prepare($statement)->execute();
                
                if (!$sql)
                {
                    echo "Sorry, Registeration proceses failed";
                }
                else
                {
                    echo "1"; 
                }
             }
             else
             {
                echo $bugs; 
             }

}
else 
{
    echo "No data enterd!";
}

?>