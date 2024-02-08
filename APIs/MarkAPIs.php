<?php

if(isset($_POST))
{ 
    require_once 'Conn.php';
    

    //SelectMark
    if($_POST['RequestType'] == "select")
    {
        $teacher = "";
        $student_id = "";
        if(isset($_POST['Student_ID']))
            $student_id =$_POST['Student_ID'];
        if(isset($_POST["teacher"]))
            $teacher = $_POST['teacher'];
        
    
    $Marks = array();
    
    if($student_id != "")
    {
        $statment = "SELECT m.ID, s.Name, s.ID AS Student, m.Mark AS Grade, m.CourseLevel AS Level, c.CourseName AS Course FROM marks m JOIN student_inf s ON m.Student_ID = s.Id JOIN courses c ON m.CourseType = c.ID WHERE Student_ID = $student_id";
    } else if($teacher != ""){
        $statment = "SELECT m.ID, s.Name, s.ID AS Student, m.Mark AS Grade, m.CourseLevel AS Level, c.CourseName AS Course FROM marks m JOIN student_inf s ON m.Student_ID = s.Id JOIN courses c ON m.CourseType = c.ID WHERE teacher = $teacher";
    }
    else
    {
        $statment = "SELECT * FROM marks";
    }

    $base = $conn->prepare($statment);
    $base -> execute();
    $data = $base -> fetch(PDO::FETCH_ASSOC);

    if ($data>0)
    {
        while($data)
        {
            $Marks[] = $data;
            $data = $base -> fetch(PDO::FETCH_ASSOC);
        }
        echo json_encode($Marks);
    }

    else
    {
        echo "ERR: No marks was found!";
    }
     
    }


#######################################################################################################################


    //updateMark
    if($_POST['RequestType'] == "update")
    {

        $ID = htmlspecialchars($_POST['MarkID']);
        $CourseLevel = htmlspecialchars($_POST['CourseLevel']);
        $CourseName = htmlspecialchars($_POST['CourseName']);
        $Mark = htmlspecialchars($_POST['Mark']);



        $bugs = [];



        if(empty($CourseName))
        {
            $bugs[]="Please, Course Name is required";
        }
        elseif(strlen($CourseName) > 2)
        {
            $bugs[]=" please, the Course_Name should be less";
        }
        elseif($CourseName < 0 || $CourseName > 22)
        {
            $bugs[]=" please, enter valid Course_Name ";
        }


        if(empty($CourseLevel))
        {
            $bugs[]="Please, Course Level is required "; 
        }
        elseif(strlen($CourseLevel) > 20)
        {
            $bugs[]=" please, the Course_Level should be less";
        }


        if(empty($Mark))
        {
            $bugs[]="Please, enter the mark "; 
        }
        elseif(strlen($Mark) > 3)
        {
            $bugs[]=" please, the mark should be less  ";
        }
        elseif($Mark < 0 || $Mark > 100)
        {
            $bugs[]=" please, enter valid mark ";
        }

        
           

        if(empty($bugs))
        {

                $statement = "UPDATE marks SET Mark = '$Mark', CourseLevel = '$CourseLevel', CourseType = '$CourseName' WHERE ID = '$ID' ";
                echo $statement;
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


    //DeleteMark
    if($_POST['RequestType'] == "delete")
    {
        $ID= $_POST['ID'];

        $statement = " DELETE FROM marks WHERE ID = '$ID' ";

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


    //InsertMark
    if($_POST['RequestType'] == "insert")
    {

        $Student_ID= htmlspecialchars($_POST['Student_ID']);
        $CourseLevel = htmlspecialchars($_POST['CourseLevel']);
        $CourseName = htmlspecialchars($_POST['CourseName']);
        $Mark = htmlspecialchars($_POST['Mark']);

        $bugs = [];



        if(empty($Student_ID))
        {
            $bugs[]="Please, Student_ID is required ";
        }
        elseif(strlen($Student_ID) > 6)
        {
            $bugs[]=" please, the Student_ID should be less  ";
        }
        $statment = "SELECT Id FROM student_inf WHERE Id = '$Student_ID' ";
        $base = $conn->prepare($statment);
        $base -> execute();
        $data = $base -> fetch(PDO::FETCH_ASSOC);

        if(!isset($_POST['id']) && !$data)
        {
            $bugs = "This student_id does not exists ";
        }



        if(empty($CourseName))
        {
            $bugs[]="Please, Course Name is required"; 
        }
        elseif(strlen($CourseName) > 2)
        {
            $bugs[]=" please, the Course_Name should be less  ";
        }
        elseif($CourseName < 0 || $CourseName > 22)
        {
            $bugs[]=" please, enter valid Course_Name ";
        }


        if(empty($CourseLevel))
        {
            $bugs[]="Please, Course Level is required "; 
        }
        elseif(strlen($CourseLevel) > 20)
        {
            $bugs[]=" please, the Course Level should be less";
        }


        if(empty($Mark))
        {
            $bugs[]="Please, enter the mark "; 
        }
        elseif(strlen($Mark) > 3)
        {
            $bugs[]=" please, the mark should be less  ";
        }
        elseif($Mark < 0 || $Mark > 100)
        {
            $bugs[]=" please, enter valid mark ";
        }





        if(empty($bugs))
            {

                $statement = "INSERT INTO marks (Student_ID, Mark, CourseLevel, CourseType) VALUES ($Student_ID, $Mark, $CourseLevel, '$CourseName')";
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