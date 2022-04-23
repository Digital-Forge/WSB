<?php
    require_once "checkAccess.php";
    require_once "PHP_adminPanel.php";
?>

<html>

<head lang="pl">
    <meta charset="utf-8"/>
    <title></title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"/>

    <link rel="stylesheet" href="CSS_panel.css" type="text/css">

    <script>
        var item_type_list = [];
        var user_type_list = [];
        var item_list = [];
        var user_list = [];
        var users_block_list = [];

        <?php

        //item_type_list
        for ($i = 0; $i < count($item_type_list); $i++) {
            echo "item_type_list.push('" . $item_type_list[$i] . "');\n";
        }

        //user_type_list
        for ($i = 0; $i < count($user_type_list); $i++) {
            echo "user_type_list.push('" . $user_type_list[$i] . "');\n";
        }

        //item_list
        for ($i = 0; $i < count($item_list); $i++) {
            echo "item_list.push(['" . $item_list[$i][0] . "', '" . $item_list[$i][1] . "', '" . $item_list[$i][2] . "', `" . $item_list[$i][3] . "`, '" . $item_list[$i][4] . "']);\n";
        }

        //user_list
        for ($i = 0; $i < count($user_list); $i++) {
            echo "user_list.push(['" . $user_list[$i][0] . "', '" . $user_list[$i][1] . "', '" . $user_list[$i][2] . "', '" . $user_list[$i][3] . "', '" . $user_list[$i][4] . "', '" . $user_list[$i][5] . "']);\n";
        }

        //users_block_list
        for ($i = 0; $i < count($users_block_list); $i++) {
            echo "users_block_list.push(['" . $users_block_list[$i][0] . "', '" . $users_block_list[$i][1] . "', '" . $users_block_list[$i][2] . "', `" . $users_block_list[$i][3] . "`, '" . $users_block_list[$i][4] . "', '" . $users_block_list[$i][5] . "', '" . $users_block_list[$i][6] . "', '" . $users_block_list[$i][7] . "', '" . $users_block_list[$i][8] . "']);\n";
        }

        ?>
    </script>

    <script type="text/javascript" src="JS_adminPanel.js"></script>

</head>

<body onload="start()">
    <div id = "container">
        <div id = "top_bar">
            <div id = "title_page"><b>System Elektronicznej Rezerwacji Zasobów Firmy</b></div>
            <a href="closeAccess.php">
                <div id = "logout">
                    Wyloguj
                </div>
            </a>
            <a href="userPanel.php">
                <div id = "switch_panel">
                    User Panel
                </div>
            </a>
            <div style="clear:both"></div>
        </div>
        <div id = "main_bar">
            <div class = "main_bar_cells" onclick="b_show_z()">
                Zablokowane
            </div>
            <div class = "main_bar_cells" onclick="b_show_em()">
                Edytuj Magazyn 
            </div>
            <div class = "main_bar_cells" onclick="b_show_eu()">
                Edytuj Użytkowników
            </div>
            <div class = "main_bar_cells" onclick="b_show_et()">
                Edytuj Typy
            </div>
            <div style="clear:both"></div>
        </div>
        <?php
        if (isset($_SESSION['db_error']))
        {
            echo '<b><span style="color:red; font-size: 20px; font-weight: bold;">Coś poszło nie tak</span></b>';
            unset($_SESSION['db_error']);
        }
        ?>
        <div id = "content_top">

        </div>
        <div id = "content">
                       
        </div>
    </div>
</body>

</html>