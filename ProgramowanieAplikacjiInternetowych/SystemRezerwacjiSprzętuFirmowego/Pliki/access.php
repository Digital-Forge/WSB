<?php
    session_start();
    $_SESSION['access'] = "false";

    if (!(isset($_POST['login']) && isset($_POST['password']))) 
    {
        header('Location: index.php');
    }

    require_once "DB_connect.php";

    $connect_db = new mysqli($db_host, $db_user, $db_password, $db_name);

    if ($connect_db->connect_errno != 0) 
    {
        session_unset();
        echo "Przepraszamy na serwerze wystąpił błąd prosimy spróbować później";
    }
    else    
    {
        $login = $_POST['login'];
        $login = htmlentities($login, ENT_QUOTES, "UTF-8");

        $password = $_POST['password'];
        //$password = password_hash($password, PASSWORD_DEFAULT);
        //echo $password;

        if ($answer_db = $connect_db->query(
            sprintf("SELECT * FROM access WHERE login = '%s'",
            mysqli_real_escape_string($connect_db, $login)))) 
        {
            if ($answer_db->num_rows > 0) {
                $row = $answer_db->fetch_assoc();

                if (password_verify($password, $row['password']))
                {
                    $_SESSION['access'] = true;
                    $_SESSION['id_user'] = $row['id_user'];
                    $answer_db->free_result();
                    $connect_db->close();
                    header('Location: accessMove.php');
                    exit();
                }
            }
            $answer_db->free_result();
        }
        $connect_db->close();
    }
    header('Location: index.php');
?>