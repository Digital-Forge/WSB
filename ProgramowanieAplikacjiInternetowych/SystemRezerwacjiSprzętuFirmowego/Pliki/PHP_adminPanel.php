<?php

require_once "DB_connect.php";

$item_type_list = [];
$user_type_list = [];

$item_list = [];
$user_list = [];

$users_block_list = [];

$connect_db = new mysqli($db_host, $db_user, $db_password, $db_name);

if ($connect_db->connect_errno != 0) {
    session_unset();
    echo "Przepraszamy na serwerze wystąpił błąd prosimy spróbować później";
} else {
    //obsługa zdarzeń
    if (isset($_POST['ini_img'], $_POST['ini_type'], $_POST['ini_name'], $_POST['ini_desc']) 
    && $_POST['ini_img'] != "" && $_POST['ini_type'] != "" && $_POST['ini_name'] != "" && $_POST['ini_desc'] != "") {
        try {
            $connect_db->query(
                "INSERT INTO `items`(`item_type`, `item_name`, `description`, `img`) 
                 VALUES ('".$_POST['ini_type']."','".$_POST['ini_name']."','".$_POST['ini_desc']."','".$_POST['ini_img']."')"
            );
        } catch (Exception $e) {
            $_SESSION['db_error'] = true;
        }
        unset($_POST['ini_img'], $_POST['ini_type'], $_POST['ini_name'], $_POST['ini_desc']);
    }

    if (isset($_POST['edi_img'], $_POST['edi_name'], $_POST['edi_desc'], $_POST['edi_id'])
        && $_POST['edi_img'] != "" && $_POST['edi_name'] != "" && $_POST['edi_desc'] != "") {
        try {
            $connect_db->query(
                "UPDATE `items` SET `item_name`='".$_POST['edi_name']."',`description`='".$_POST['edi_desc']."',`img`='".$_POST['edi_img']."' WHERE `id_item` = ".$_POST['edi_id']
            );
        } catch (Exception $e) {
            $_SESSION['db_error'] = true;
        }
        unset($_POST['edi_img'], $_POST['edi_name'], $_POST['edi_desc'], $_POST['edi_id']);
    }

    if (isset($_POST['adu_name'], $_POST['adu_surname'], $_POST['adu_phone1'], $_POST['adu_phone2'], $_POST['adu_phone3'], $_POST['adu_typ'], $_POST['adu_login'], $_POST['adu_haslo']) 
    && $_POST['adu_name'] != "" && $_POST['adu_surname'] != "" && $_POST['adu_phone1'] != "" && $_POST['adu_phone2'] != "" && $_POST['adu_phone3'] != "" && $_POST['adu_typ'] != "" && $_POST['adu_login'] != "" && $_POST['adu_haslo'] != "") {
        try {
            $connect_db->query(
                "INSERT INTO `access`(`login`, `password`) 
                 VALUES ('".$_POST['adu_login']."','".password_hash($_POST['adu_haslo'], PASSWORD_DEFAULT)."')"
            );
        } catch (Exception $e) {
            $_SESSION['db_error'] = true;
            goto adu_exit;
        }
        $result = $connect_db->query("SELECT id_user FROM access WHERE login = '".$_POST['adu_login']."'");
        $result = $result->fetch_assoc();

        try {
            $connect_db->query(
                "INSERT INTO `users`(`id_user`, `user_type`, `name`, `surname`, `phone`) 
                 VALUES (".$result['id_user'].",'".$_POST['adu_typ']."','".$_POST['adu_name']."','".$_POST['adu_surname']."','".$_POST['adu_phone1']."-".$_POST['adu_phone2']."-".$_POST['adu_phone3']."')"
            );
        } catch (Exception $e) {
            $_SESSION['db_error'] = true;
        }

        adu_exit:
        unset($_POST['adu_name'], $_POST['adu_surname'], $_POST['adu_phone1'], $_POST['adu_phone2'], $_POST['adu_phone3'], $_POST['adu_typ'], $_POST['adu_login'], $_POST['adu_haslo']);
    }

    if (isset($_POST['edu_id'], $_POST['edu_name'], $_POST['edu_surname'], $_POST['edu_phone1'], $_POST['edu_phone2'], $_POST['edu_phone3'], $_POST['edu_login'], $_POST['edu_typ']) 
    && $_POST['edu_id'] != "" && $_POST['edu_name'] != "" && $_POST['edu_surname'] != "" && $_POST['edu_phone1'] != "" && $_POST['edu_phone2'] != "" && $_POST['edu_phone3'] != "" && $_POST['edu_login'] != "" && $_POST['edu_typ'] != "") {
        try {
            $connect_db->query("UPDATE `access` SET `login`='".$_POST['edu_login']."' WHERE id_user = ".$_POST['edu_id']);
        } catch (Exception $e) {
            $_SESSION['db_error'] = true;
            goto edu_exit;
        }

        try {
            $connect_db->query("UPDATE `users` SET `user_type`='".$_POST['edu_typ']."',`name`='".$_POST['edu_name']."',`surname`='".$_POST['edu_surname']."',`phone`='".$_POST['edu_phone1']."-".$_POST['edu_phone2']."-".$_POST['edu_phone3']."' WHERE id_user = ".$_POST['edu_id']);
        } catch (Exception $e) {
            $_SESSION['db_error'] = true;
        }

        edu_exit:
        unset($_POST['edu_id'], $_POST['edu_name'], $_POST['edu_surname'], $_POST['edu_phone1'], $_POST['edu_phone2'], $_POST['edu_phone3'], $_POST['edu_login'], $_POST['edu_typ']);
    }

    if (isset($_POST['deli_id'])) {
        try {
            @$connect_db->query(
                "DELETE FROM block_items WHERE id_item = " . $_POST['deli_id']
            );
        } catch (Exception $e) {
            $_SESSION['db_error'] = true;
        }

        try {
            $connect_db->query(
                "DELETE FROM items WHERE id_item = " . $_POST['deli_id']
            );
        } catch (Exception $e) {
            $_SESSION['db_error'] = true;
        }
        unset($_POST['deli_id']);
    }

    if (isset($_POST['delu_id'])) {
        try {
            @$connect_db->query(
                "DELETE FROM block_items WHERE id_user = " . $_POST['delu_id']
            );
        } catch (Exception $e) {
            $_SESSION['db_error'] = true;
        }

        try {
            $connect_db->query(
                "DELETE FROM users WHERE id_user = " . $_POST['delu_id']
            );
        } catch (Exception $e) {
            $_SESSION['db_error'] = true;
        }

        try {
            $connect_db->query(
                "DELETE FROM access WHERE id_user = " . $_POST['delu_id']
            );
        } catch (Exception $e) {
            $_SESSION['db_error'] = true;
        }
        unset($_POST['delu_id']);
    }

    if (isset($_POST['eduh_id'], $_POST['edu_password'])
        && $_POST['eduh_id'] != "" && $_POST['edu_password'] != "") {
        try {
            $connect_db->query(
                "UPDATE `access` SET `password`='".password_hash($_POST['edu_password'], PASSWORD_DEFAULT)."' WHERE id_user = " . $_POST['eduh_id']
            );
        } catch (Exception $e) {
            $_SESSION['db_error'] = true;
        }
        unset($_POST['eduh_id'], $_POST['edu_password']);
    }

    if (isset($_POST['ret_id'])) {
        try {
            $connect_db->query(
                "DELETE FROM block_items WHERE id_item = " . $_POST['ret_id']
            );
        } catch (Exception $e) {
            $_SESSION['db_error'] = true;
        }
        unset($_POST['ret_id']);
    }

    if (isset($_POST['delit_name'])) {
        try {
            $connect_db->query(
                "DELETE FROM items_type WHERE item_type = '" . $_POST['delit_name']."'"
            );
        } catch (Exception $e) {
            $_SESSION['db_error'] = true;
        }
        unset($_POST['delit_name']);
    }

    if (isset($_POST['delut_name'])) {
        try {
            $connect_db->query(
                "DELETE FROM users_type WHERE user_type = '" . $_POST['delut_name']."'"
            );
        } catch (Exception $e) {
            $_SESSION['db_error'] = true;
        }
        unset($_POST['delut_name']);
    }

    if (isset($_POST['adut_name'])) {
        try {
            $connect_db->query(
                "INSERT INTO `users_type`(`user_type`) VALUES ('". $_POST['adut_name']."')"
            );
        } catch (Exception $e) {
            $_SESSION['db_error'] = true;
        }
        unset($_POST['adut_name']);
    }

    if (isset($_POST['adit_name'])) {
        try {
            $connect_db->query(
                "INSERT INTO `items_type`(`item_type`) VALUES ('". $_POST['adit_name']."')"
            );
        } catch (Exception $e) {
            $_SESSION['db_error'] = true;
        }
        unset($_POST['adit_name']);
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

    //user_type_list
    if ($answer_db = $connect_db->query("SELECT * FROM users_type")) {
        if ($answer_db->num_rows > 0) {

            while ($row = $answer_db->fetch_assoc()) {
                array_push($user_type_list, $row['user_type']);
            }
        }
        $answer_db->free_result();
    }

    //item_list
    if ($answer_db = $connect_db->query("SELECT * FROM items")) {
        if ($answer_db->num_rows > 0) 
        {
            while ($row = $answer_db->fetch_assoc()) {
                array_push($item_list, [$row['id_item'], $row['item_type'], $row['item_name'], $row['description'], $row['img']]);
            }
        }
        $answer_db->free_result();
    }

    //user_list
    if ($answer_db = $connect_db->query("SELECT * FROM users NATURAL JOIN access")) {
        if ($answer_db->num_rows > 0) 
        {
            while ($row = $answer_db->fetch_assoc()) {
                array_push($user_list, [$row['id_user'], $row['user_type'], $row['login'], $row['name'], $row['surname'], $row['phone']]);
            }
        }
        $answer_db->free_result();
    }

    //users_block_list
    if ($answer_db = $connect_db->query("SELECT id_item, item_type, item_name, description, img, date_start, date_end, name, surname, phone FROM items NATURAL JOIN block_items NATURAL JOIN users")) {
        if ($answer_db->num_rows > 0) 
        {
            while ($row = $answer_db->fetch_assoc()) {
                array_push($users_block_list, [$row['id_item'], $row['item_type'], $row['item_name'], $row['description'], $row['img'], $row['date_start'], $row['date_end'], $row['name']." ".$row['surname'], $row['phone']]);
            }
        }
        $answer_db->free_result();
    }

    
    $connect_db->close();
}
