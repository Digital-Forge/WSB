<?php
require_once "checkAccess.php";
require_once "PHP_userPanel.php";
?>

<html>

<head lang="pl">
    <meta charset="utf-8" />
    <title></title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />

    <link rel="stylesheet" href="CSS_panel.css" type="text/css">

    <script>
        var item_type_list = [];
        var item_list = [];
        var my_item_list = [];
        var users_block_list = [];

        <?php
        //item_type_list
        for ($i = 0; $i < count($item_type_list); $i++) {
            echo "item_type_list.push('" . $item_type_list[$i] . "');\n";
        }

        //item_list
        for ($i = 0; $i < count($item_list); $i++) {
            echo "item_list.push(['" . $item_list[$i][0] . "', '" . $item_list[$i][1] . "', '" . $item_list[$i][2] . "', `" . $item_list[$i][3] . "`, '" . $item_list[$i][4] . "', '" . $item_list[$i][5] . "']);\n";
        }

        //my_item_list
        for ($i = 0; $i < count($my_item_list); $i++) {
            echo "my_item_list.push(['" . $my_item_list[$i][0] . "', '" . $my_item_list[$i][1] . "', '" . $my_item_list[$i][2] . "', `" . $my_item_list[$i][3] . "`, '" . $my_item_list[$i][4] . "', '" . $my_item_list[$i][5] . "']);\n";
        }

        //users_block_list
        for ($i = 0; $i < count($users_block_list); $i++) {
            echo "users_block_list.push(['" . $users_block_list[$i][0] . "', '" . $users_block_list[$i][1] . "', '" . $users_block_list[$i][2] . "', '" . $users_block_list[$i][3] . "']);\n";
        }
        ?>

        var show_item_list = item_list;
    </script>

    <script type="text/javascript" src="JS_userPanel.js"></script>

</head>

<body onload="start()">
    <div id="container">
        <div id="top_bar">
            <div id="title_page"><b>System Elektronicznej Rezerwacji Zasobów Firmy</b></div>
            <div id=logout>
                <a href="closeAccess.php">Wyloguj</a>
            </div>
            <?php if (isset($_SESSION['admin'])) {
                echo '<a href="adminPanel.php"><div id = switch_panel>Admin Panel</div></a>';
            } ?>
            <div style="clear:both"></div>
        </div>
        <div id="main_bar">
            <div class="main_bar_cells" onclick="b_show_r()">
                Rezerwuj
            </div>
            <div class="main_bar_cells" onclick="b_show_mr()">
                Moje Rezerwacje
            </div>
            <div class="main_bar_cells" style="float: right;" onclick="b_show_zh()">
                Zmień Hasło
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
        <div id="content_top">

        </div>
        <div id="content">
            
        </div>
    </div>
</body>

</html>