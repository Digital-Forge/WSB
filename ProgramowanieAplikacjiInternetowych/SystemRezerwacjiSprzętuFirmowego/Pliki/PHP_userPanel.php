<?php
require_once "DB_connect.php";

$item_type_list = [];
$item_list = [];
$my_item_list = [];
$users_block_list = [];

$passInfo = "";

$connect_db = new mysqli($db_host, $db_user, $db_password, $db_name);

if ($connect_db->connect_errno != 0) {
    session_unset();
    echo "Przepraszamy na serwerze wystąpił błąd prosimy spróbować później";
} else {
    //obsługa zdarzeń
    if (isset($_POST['res_id'], $_POST['res_date'])) 
    {
        try 
        {
            $connect_db->query(
                "INSERT INTO `block_items`(`id_item`, `id_user`, `date_start`, `date_end`) 
                 VALUES (".$_POST['res_id'].",".$_SESSION['id_user'].",'".date("Y-m-d")."','".$_POST['res_date']."')");
        } 
        catch (Exception $e) 
        {
            $_SESSION['db_error'] = true;
        }  
        unset($_POST['res_id']);
        unset($_POST['res_date']);
    }

    if (isset($_POST['ret_id'])) 
    {
        try 
        {
            $connect_db->query(
                "DELETE FROM block_items WHERE id_item = ".$_POST['ret_id']);
        } 
        catch (Exception $e) 
        {
            $_SESSION['db_error'] = true;
        }  
        unset($_POST['ret_id']);
    }

    if (isset($_POST['password1'], $_POST['password2'])
        && $_POST['password1'] != "" && $_POST['password2'] != "") 
        {
            if ($_POST['password1'] == $_POST['password2']) {
                try {
                    $connect_db->query(
                        "UPDATE `access` SET `password`='".password_hash($_POST['password1'], PASSWORD_DEFAULT)."' WHERE id_user = " . $_SESSION['id_user']
                    );
                } catch (Exception $e) {
                    $passInfo = "Nie udało się zmienić. Spróbuj później";
                }
            } else {
                $passInfo = "Hasła nie zgodne";
            }
        unset($_POST['password1'], $_POST['password2']);
    }


    //item_type_list
    if ($answer_db = $connect_db->query("SELECT * FROM items_type")) {
        if ($answer_db->num_rows > 0) {

            while ($row = $answer_db->fetch_assoc()) {
                array_push($item_type_list, $row['item_type']);
            }
        }
        $answer_db->free_result();
    }

    //my_item_list
    if ($answer_db = $connect_db->query(
        sprintf(
            "SELECT * FROM block_items NATURAL JOIN items WHERE id_user = '%s'",
            $_SESSION['id_user']
        )))
     {
        if ($answer_db->num_rows > 0) {

            while ($row = $answer_db->fetch_assoc()) {
                array_push($my_item_list, [$row['id_item'], $row['item_type'], $row['item_name'], $row['description'], $row['img'], $row['date_end']]);
            }
        }
        $answer_db->free_result();
    }

    //item_list
    if ($answer_db = $connect_db->query("SELECT * FROM block_items NATURAL JOIN items NATURAL JOIN users")) {
        if ($answer_db->num_rows > 0) {

            $i = 0;
            while ($row = $answer_db->fetch_assoc()) {
                array_push($item_list, [$row['id_item'], $row['item_type'], $row['item_name'], $row['description'], $row['img'], $i]);
                array_push($users_block_list, [$row['date_end'], $row['name'], $row['surname'], $row['phone']]);
                $i++;
            }
        }
        $answer_db->free_result();
    }

    if ($answer_db = $connect_db->query(
        "SELECT id_item, item_type, item_name, description, img FROM items 
            EXCEPT 
             SELECT id_item, item_type, item_name, description, img FROM block_items NATURAL JOIN items"
    )) {
        if ($answer_db->num_rows > 0) {

            while ($row = $answer_db->fetch_assoc()) {
                array_push($item_list, [$row['id_item'], $row['item_type'], $row['item_name'], $row['description'], $row['img'], -1]);
            }
        }
        $answer_db->free_result();
    }
    $connect_db->close();
}
