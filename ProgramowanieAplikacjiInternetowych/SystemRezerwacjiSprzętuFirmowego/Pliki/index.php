<?php
    require_once "PHP_index.php";
?>

<html>

<head lang="pl">
    <meta charset="utf-8"/>
    <title></title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"/>

    <link rel="stylesheet" href="CSS_index.css" type="text/css">

    <script type="text/javascript" src="JS_index.js"></script>

</head>

<body onload="load()">
    <div id="contener">
        <div id=content>
            <form action = "access.php" method = "POST">
                <div>
                    <div class="text_login">
                        Login
                    </div>
                    <div class="input_login">
                        <input type="text" id="login" name = "login" /><br />
                    </div>
                    <div style="clear:both"></div>
                </div>
                <div>
                    <div class="text_login">
                        Hasło
                    </div>
                    <div class="input_login">
                        <input type="password" id="password" name = "password" /><br />
                    </div>
                    <div style="clear:both"></div>
                </div>
                <div>
                    <?php echo $accessInfo ?>
                </div>
                <div>
                    <input type="submit" id="b_login" value="Zaloguj">
                </div>
            </form>
        </div>
    </div>
</body>

</html>