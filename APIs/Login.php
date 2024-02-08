<?php

if(isset($_POST))
{ 
    require_once 'Conn.php';
    $username= htmlspecialchars($_POST['username']);
    $password = htmlspecialchars($_POST['password']);
    $bugs = [];

    if(empty($username))
    {
        $bugs[]="Username is required! ";
    }

    if(empty($password))
    {
        $bugs[]="Password is required!";
    }

    if(empty($bugs))
    {
        $statment = " select Username , Password  FROM admin_users WHERE Username  = '$username' and Password = '" . Crypt(md5($password), sha1($password)) . "' ";
        $query = $conn->prepare($statment);
        $base -> execute();
        $data = $base -> fetch(PDO::FETCH_ASSOC);

        if (!$data)
        {
            echo "Sorry, you are not registered yet";    }
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