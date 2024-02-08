<?php

if(isset($_POST))
{ 
    require_once 'Conn.php';
    
    //SelectTeacher
    if($_POST['RequestType'] == "select")
    {
        $username = "";
        if(isset($_POST['username'])) $username=$_POST['username'];
        
        $Teachers = array();

        if ($username != "")
        {
            $statment = "SELECT ID, Username, Password, Mobile AS PhoneNumber, Name, Email, Salary, Status FROM teachers WHERE Username = '$username' ";
        }
        
        else 
        {
            $statment = "SELECT ID, Username, Password, Mobile AS PhoneNumber, Name, Email, Salary, Status FROM teachers ";
        }
        $base = $conn->prepare($statment);
        $base -> execute();
        $data = $base -> fetch(PDO::FETCH_ASSOC);

        if ($data>0)
        {
            while($data)
            {
                $Teachers[] = $data;
                $data = $base -> fetch(PDO::FETCH_ASSOC);
            }
            echo json_encode($Teachers);
        }

        else
        {
            echo "ERR: No teachers was found!";
        }
    
    }


#######################################################################################################################


    //updateTeacher
    if($_POST['RequestType'] == "update")
    {

    $ID = $_POST['ID'];
    $name = htmlspecialchars($_POST['name']);
    $username = htmlspecialchars($_POST['username']);
    $password = htmlspecialchars($_POST['password']);
    $email = filter_var($_POST['email'] , FILTER_SANITIZE_EMAIL);
    $tel = filter_var($_POST['mobile'] , FILTER_SANITIZE_NUMBER_INT);
    $salary = filter_var($_POST['salary'],FILTER_SANITIZE_NUMBER_FLOAT);


    $bugs = [];
    /*
    if(empty($ID))
    {
    $bugs[]="Please enter the Id "; 
    }*/


    

    if(empty($name))
    {
        $bugs[]="Please, enter the name ";
    }
    elseif(strlen($name) > 50)
    {
        $bugs[]=" please, the name should be less  ";
    }


        

    if(empty($email))
    {
        $bugs[]="Please email is required ";
    }
    elseif(filter_var($email , FILTER_SANITIZE_EMAIL) == false )
    {
        $bugs[]="Email is wrong ";
    }

    $stm = "SELECT Email FROM teachers WHERE Email = '$email'  AND ID != $ID";
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
    




    if(empty($username))
    {
        $bugs[]="Please enter the usernaem ";
    }
    
    $statement = "SELECT Username FROM teachers WHERE Username = '$username' AND ID != $ID";
    $base = $conn->prepare($statement);
    $base -> execute();
    $data = $base -> fetch(PDO::FETCH_ASSOC);

    if($data)
    {
        $bugs[] = "Username is already exist ";
    }




    if(empty($salary))
    {
        $bugs[]="Please, enter the salary ";
    }
    elseif(strlen($salary) < 5 || strlen($salary) > 6)
    {
        $bugs[]="The salary must be 5-6 digits ";
    }


    
    
    if(empty($bugs))
    {
        /*$statement = "INSERT INTO teachers (Email, Mobile, Username, Password, Name, Salary) VALUES ('$email', $tel, '$username', '$encryptedPassword', '$name', $salary)";*/
        //if(isset($_POST['id']))
        //{
            $statement = "UPDATE teachers  SET Email = '$email', Mobile = $tel, Username = '$username', name = '$name', Salary = $salary";
            if($password != ""){
                $statement .= ", Password = '$password'";
            }
            $statement .= " WHERE ID = '$ID'";
        //}
        $update_sql = $conn->prepare($statement)->execute();
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
        echo "ERR";
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
    
        $statement = "SELECT Username, Status FROM teachers WHERE Username = '$username' ";
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

            $statement = "UPDATE teachers SET Status = $status WHERE Username = '$username'";
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


    //DeleteTeacher
    if($_POST['RequestType'] == "delete")
    {
        
        $username = htmlspecialchars($_POST['username']);
        if($username != "")
        {
            $statement = " DELETE FROM teachers WHERE Username = '$username' ";
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
        
        else 
        {
            echo "ERR";;
        }
        
 
    }


#######################################################################################################################


    //InsertTeacher
    if($_POST['RequestType'] == "insert")
    {
        $name = htmlspecialchars($_POST['name']);
        $username = htmlspecialchars($_POST['username']);
        $password = htmlspecialchars($_POST['password']);
        $tel = filter_var($_POST['mobile'] , FILTER_SANITIZE_NUMBER_INT);
        $email = filter_var($_POST['email'] , FILTER_SANITIZE_EMAIL);
        $salary = filter_var($_POST['salary'] , FILTER_SANITIZE_NUMBER_FLOAT);


        $bugs = [];



        if(empty($name))
        {
            $bugs[]="Please enter your name ";
        }
        elseif(strlen($name) > 50)
        {
            $bugs[]=" please the name should be less  ";
        }


        if(empty($username))
        {
            $bugs[]="Please enter your usernaem ";
        }

        $stm = "SELECT Username FROM teachers WHERE Username = '$username'";
        $base = $conn->prepare($stm);
        $base -> execute();
        $data = $base -> fetch(PDO::FETCH_ASSOC);

        if($data)
        {
            $bugs[] = "Username is already used ";
        }

        if(empty($password))
        {
            $bugs[]="Please enter your password ";
        }
        elseif(strlen($password) < 6)
        {
            $bugs[]="The password must be more than 6 characters";
        }

        if(empty($email))
        {
            $bugs[]="Please enter your email";
        }
        elseif(filter_var($email , FILTER_SANITIZE_EMAIL) == false )
        {
            $bugs[]="Email is wrong";
        }

        $stm = "SELECT Email FROM teachers WHERE Email = '$email'";
        $base = $conn->prepare($stm);
        $base -> execute();
        $data = $base -> fetch(PDO::FETCH_ASSOC);

        if($data)
        {
            $bugs[] = "Email is already used ";
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

        if(empty($salary))
        {
            $bugs[]="Please, enter the salary ";
        }
        elseif(strlen($salary) < 5 || strlen($salary) > 6)
        {
            $bugs[]="The salary must be 5-6 digits ";
        }





        if(empty($bugs))
            {
                $statement = "INSERT INTO teachers (Name, Username, Password, Mobile, Email, Salary) VALUES ('$name', '$username', '$password', $tel, '$email', $salary)";
                $sql = $conn->prepare($statement)->execute();
                
                if (!$sql)
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
            echo "ERR";
        }

    }
}

else 
{
    echo "ERR";
}

?>