<?php
    session_start();

    if (isset($_SESSION['access']))
    {
        if ($_SESSION['access'] != 'true') 
        {
            header('Location: index.html');
            exit();
        }
    }
    else
    {
        session_unset();
        header('Location: index.html');
        exit();
    }
?>