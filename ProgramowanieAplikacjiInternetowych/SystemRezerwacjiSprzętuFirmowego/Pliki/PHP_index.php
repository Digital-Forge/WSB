<?php
    session_start();
    $accessInfo = "";

    if (isset($_SESSION['access']))
    {
        switch ($_SESSION['access']) {
            case 'true':
                header('Location: accessMove.php');
                exit();
                break;
            case 'false':
                $accessInfo = "Brak dostępu - dane nieprawidłowe";
                unset($_SESSION['access']);
                break;    
            default:
                $accessInfo = "";
                unset($_SESSION['access']);
                break;
        }
    }
?>