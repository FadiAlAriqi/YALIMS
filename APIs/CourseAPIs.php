<?php

if(isset($_POST))
{ 
    require_once '../Conn.php';
    




    //SelectCourse
    if($_POST['RequestType'] == "select")
    {

        $Course=$_POST['Course'];
        $ID = $_POST['Id'];
        $Courses = array();
        
        if ($ID != "")
        {
            $statment = "SELECT * FROM courses WHERE ID = '$ID'";
        }
        else if($Course != "" && $ID == "")
        {
            $statment = "SELECT Level FROM courses WHERE CourseName = '$Course' ";
        }
        else 
        {
            $statment = "SELECT * FROM courses ";
        }
        $base = $conn->prepare($statment);
        $base -> execute();
        $data = $base -> fetch(PDO::FETCH_ASSOC);

        if ($data>0)
        {
            while($data)
            {
                $Courses[] = $data;
                $data = $base -> fetch(PDO::FETCH_ASSOC);
            }
            echo json_encode($Courses);
        }

        else
        {
            echo "ERR";;
        }
     
    }


#######################################################################################################################


    //updateCourse
    if($_POST['RequestType'] == "update")
    {

        $ID = $_POST['id'];
        $Course_Name = htmlspecialchars($_POST['Course_Name']);
    
        $bugs = [];
    
    
        if(empty($ID))
        {
        $bugs[]="Please enter the Id "; 
        }
    
    
        if(empty($CourseName))
        {
            $bugs[]="Please, Course_Name is required ";
        }
        elseif(strlen($CourseName) > 30)
        {
            $bugs[]=" please, the Course_Name should be less  ";
        }



        if(empty($bugs))
        {
            
            $statement = "INSERT INTO courses (CourseName) VALUES ('$Course_Name')";
            if(isset($_POST['id']))
            {                
            $statement = "UPDATE courses  SET CourseName = '$Course_Name' WHERE ID = '$ID' ";                
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


    //DeleteCourse
    if($_POST['RequestType'] == "delete")
    {
        $ID = $_POST['ID'];

        $statement = " DELETE FROM courses WHERE ID = '$ID' ";
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


    //InsertCourse
    if($_POST['RequestType'] == "insert")
    {

        $Course_Name = htmlspecialchars($_POST['CourseName']);
        $bugs = [];


        if(empty($Course_Name))
        {
            $bugs[]="Please, Course_Name is required ";
        }
        elseif(strlen($Course_Name) > 30)
        {
            $bugs[]=" please, the Course_Name should be less  ";
        }




            if(empty($bugs))
             {

                $statement = "INSERT INTO courses (CourseName) VALUES ('$Course_Name')";
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
