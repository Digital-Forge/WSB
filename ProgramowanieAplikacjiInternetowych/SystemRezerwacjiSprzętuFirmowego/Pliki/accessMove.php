<?php
    require_once "checkAccess.php";

    require_once "DB_connect.php";

    $connect_db = new mysqli($db_host, $db_user, $db_password, $db_name);

    if ($connect_db->connect_errno != 0) 
    {
        session_unset();
        echo "Przepraszamy na serwerze wystąpił błąd prosimy spróbować później";
    }
    else    
    {
        if ($answer_db = $connect_db->query(
            sprintf("SELECT user_type FROM users WHERE id_user = '%s'",
            $_SESSION['id_user']))) 
        {
            if ($answer_db->num_rows > 0) {
                $row = $answer_db->fetch_assoc();

                switch ($row['user_type']) {
                    case 'system':
                        # code...
                        break;
                    case 'admin':
                        $_SESSION['admin'] = 'true';
                        break;
                    case 'user':
                        # code...
                        break;         
                    default:
                        # code...
                        break;
                }
                
            }
            $answer_db->free_result();
        }
        $connect_db->close();
    }
    header('Location: userPanel.php');
?>