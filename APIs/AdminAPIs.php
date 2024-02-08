<?php

if(isset($_POST))
{ 
    require_once 'Conn.php';
    

    //SelectAdmin
    if($_POST['RequestType'] == "select")
    {
        $username = "";
        if(isset($_POST['username'])) $username=$_POST['username'];
        $Admins = array();

        if($username == "")
        {
            $statment = "SELECT ID, Username, Password, Mobile as PhoneNumber, Email, Status FROM admin_users";
        }
        else
        {
            $statment = "SELECT ID, Username, Password, Mobile as PhoneNumber, Email, Status FROM admin_users WHERE Username = '$username' ";
        }
        $base = $conn->prepare($statment);
        $base -> execute();
        $data = $base -> fetch(PDO::FETCH_ASSOC);
    

        if ($data>0)
        {
            while($data)
            {
                $Admins[] = $data;
                $data = $base -> fetch(PDO::FETCH_ASSOC);
            }
            echo json_encode($Admins);
        }
    
        else
        {
            echo "ERR: No admin was found!";
        }
    
    }


#######################################################################################################################


    //updateAdmin
    if($_POST['RequestType'] == "update")
    {
        $ID = $_POST['id'];
        $username = htmlspecialchars($_POST['username']);
        $password = htmlspecialchars($_POST['password']);
        $email = filter_var($_POST['email'] , FILTER_SANITIZE_EMAIL);
        $tel = filter_var($_POST['phone'] , FILTER_SANITIZE_NUMBER_INT);
        
        
        $bugs = [];
        
        
    
        if(empty($ID))
        {
        $bugs[]="Please enter the Id ";
        }



        if(empty($username))
        {
            $bugs[]="Please enter the usernaem";
        }
        $statement = "SELECT Username FROM admin_users WHERE Username = '$username' and ID != '$ID'";
        $base = $conn->prepare($statement);
        $base -> execute();
        $data = $base -> fetch(PDO::FETCH_ASSOC);

        if($data)
        {
            $bugs[] = "Username is already exist";
        }




        
        if(empty($email))
        {
            $bugs[]="Please email is required";
        }
        elseif(filter_var($email , FILTER_SANITIZE_EMAIL) == false )
        {
            $bugs[]="Email is wrong";
        }

        $stm = "SELECT Email FROM admin_users WHERE Email = '$email' AND ID != $ID"; // 
        $base = $conn->prepare($stm);
        $base -> execute();
        $data = $base -> fetch(PDO::FETCH_ASSOC);

        if($data)
        {
            $bugs[] = "Email is already exist";
        }


        if(strlen($password) < 6 && $password != "")
        {
            $bugs[]="The password must be more than 6 characters";
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
        




    
        if(empty($bugs))
        {
            if(isset($_POST['id']))
            {
            $statement = "UPDATE admin_users SET Username = '$username', Mobile = $tel, Email = '$email'";
            if($password != ""){
                $statement .= ", Password = '$password'";
            }
            $statement .= " WHERE ID = '$ID' ";
            }

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


    ////activate Admin
    if($_POST['RequestType'] == "activate")
    {
        $username = htmlspecialchars($_POST['username']);
        $bugs = [];
    

        if(empty($username))
        {
            $bugs[]="Please enter the usernaem ";
        }
    
        $statement = "SELECT Username, Status FROM admin_users WHERE Username = '$username' ";
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

            $statement = "UPDATE admin_users SET Status = $status WHERE Username = '$username'";
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


    //DeleteAdmin
    if($_POST['RequestType'] == "delete")
    {
        $ID = $_POST['ID'];    
    
        $statement = " DELETE FROM admin_users WHERE ID = '$ID' ";
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


#######################################################################################################################


    //InsertAdmin
    if($_POST['RequestType'] == "insert")
    {

        $username = htmlspecialchars($_POST['username']);
        $password = htmlspecialchars($_POST['password']);
        $tel = filter_var($_POST['phone'] , FILTER_SANITIZE_NUMBER_INT);
        $email = filter_var($_POST['email'] , FILTER_SANITIZE_EMAIL);

        $bugs = [];


        if(empty($username))
        {
            $bugs[]="Please enter your usernaem ";
        }

        $stm = "SELECT Username FROM admin_users WHERE Username	 = '$username' ";
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
            $bugs[]="The password must be more than 6 characters ";
        }



            if(empty($email))
            {
                $bugs[]="Please enter your email ";
            }
            elseif(filter_var($email , FILTER_SANITIZE_EMAIL) == false )
            {
                $bugs[]="Email is wrong ";
            }

            $stm = "SELECT Email FROM admin_users WHERE Email = '$email' ";
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





        if(empty($bugs))
        {
            $statement = "INSERT INTO admin_users (Username, Password, Mobile, Email) VALUES ('$username', '$password', $tel, '$email')";
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
        echo "ERR";; 
        }

    }





}

else 
{
    echo "ERR";;
}

?>