<?php
if (isset($_POST['pass'])) {
    $pass = $_POST['pass'];
    unset($_POST['pass']);
    $pass = password_hash($pass, PASSWORD_DEFAULT);
    echo $pass;
}
?>

<form action="" method="POST">
    <input type="text" name="pass">
    <input type="submit" value="GO">
</form>