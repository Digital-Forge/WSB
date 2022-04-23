var show_page = "z";
var show_page_status = 0;

function start() {
    switch (show_page) {
        case "z":
            show_z();
            break;
        case "em":
            show_em();
            break;
        case "eu":
            show_eu();
            break;
        case "et":
            show_et();
            break;
    }
}

function b_show_z() {
    show_page = "z";
    show_page_status = 0;
    show_z();
}

function b_show_em() {
    show_page = "em";
    show_page_status = 0;
    show_em();
}

function b_show_eu() {
    show_page = "eu";
    show_page_status = 0;
    show_eu();
}

function b_show_et() {
    show_page = "et";
    show_page_status = 0;
    show_et();
}

function show_z() {

    var gen_content = "";

    for (let i = 0; i < users_block_list.length; i++) {
        gen_content += `
            <div class = "item_box">
                <div class = "item_box_img">
                    <img class = "item_box_img" src="`+ users_block_list[i][4] + `" alt="">
                </div>
                <div class = "item_box_text">
                    <b>`+ users_block_list[i][1] + `</b> : ` + users_block_list[i][0] + `<br/>
                    <b>`+ users_block_list[i][2] + `</b>
                    <div class = "item_box_text_desc">
                        `+ users_block_list[i][3] + `
                    </div>
                </div>
                <div class = "item_box_action">
                    <div class = "item_box_action_block2">
                        <b>Zablokowane</b><br/>
                        Termin : `+ users_block_list[i][5] + `<br/> do ` + users_block_list[i][6] + `<br/>
                        `+ users_block_list[i][7] + `<br/>
                        `+ users_block_list[i][8] + `
                        <form action="adminPanel.php" method="POST">
                            <input type="hidden" name = "ret_id" value = "` + users_block_list[i][0] + `">
                            <input type="submit" class = "item_box_action_block2_button" value = "Zwolnij">
                        </form>
                    </div> 
                </div>
                <div style="clear:both"></div>
            </div>`;

    }

    if (gen_content == "") 
    {
        gen_content = '<b><span style = "font-size: 20px;">Brak Zarezerwowanych Zasobów</span></b>';
    }

    document.getElementById('content').innerHTML = gen_content;
    document.getElementById('content_top').innerHTML = "";
}

function show_em() {
    var gen_content = "";

    for (let i = 0; i < item_list.length; i++) {
        gen_content += `
            <div class = "item_box2">
                <form action="adminPanel.php" method="POST">
                <div class = "item_box_img">
                    <img class = "item_box_img" src="`+ item_list[i][4] + `" alt=""><br/>
                    <input type = "text" class = "ini_img" name = "edi_img" value = "`+ item_list[i][4] + `">
                </div>
                <div class = "item_box_text">
                    <div class = "item_box_text_info">
                    <b>`+ item_list[i][1] + `</b> : ` + item_list[i][0] + `<br/>
                    <b><input type = "text" class = "ini_img" name = "edi_name" value = "`+ item_list[i][2] + `"></b>
                    </div>
                    <div class = "item_box_text_desc">
                        <textarea name="edi_desc" rows="10" cols="60">`+ item_list[i][3] + `</textarea>
                    </div>
                </div>
                <div class = "item_box_action">
                    <div class = "item_box_action_block2">
                        
                            <input type="hidden" name = "edi_id" value = "` + item_list[i][0] + `">
                            <input type="submit" class = "item_box_action_block2_button" value = "Zapisz">
                        </form>
                        <form action="adminPanel.php" method="POST">
                            <input type="hidden" name = "deli_id" value = "` + item_list[i][0] + `">
                            <input type="submit" class = "item_box_action_block2_button" value = "Usuń">
                        </form>
                    </div> 
                </div>
                <div style="clear:both"></div>
            </div>`;

    }

    var gen_content_top = "";

    gen_content_top += `
            <div class = "item_box2">
                <form action="adminPanel.php" method="POST">
                    <div class = "item_box_img">
                        <img class = "item_box_img" src="img/base_img.png" alt=""><br/>
                        <input type = "text" class = "ini_img" name = "ini_img" value = "img/base_img.png">
                    </div>
                    <div class = "item_box_text">
                        <div class = "item_box_text_info">
                        <select class = "select_item" name="ini_type" ">
                            <option value="" style="display:none"></option>`;

    for (let i = 0; i < item_type_list.length; i++) {
        gen_content_top += '<option value="' + item_type_list[i] + '">' + item_type_list[i] + '</option>';
    }

    gen_content_top += `
                        </select><br/>
                        <input type = "text" class = "ini_img" name = "ini_name">
                        </div>
                        <div class = "item_box_text_desc">
                            <textarea name="ini_desc" rows="10" cols="60"></textarea>
                        </div>
                    </div>
                    <div class = "item_box_action"><br/><br/><br/><br/>
                        <input type="submit" class = "item_box_action_button3" value = "Dodaj">
                    </div>
                    <div style="clear:both"></div>
                </form>
            </div>`;


    if (gen_content == "") 
    {
        gen_content = '<b><span style = "font-size: 20px;">Brak Zasobów</span></b>';
    }


    document.getElementById('content').innerHTML = gen_content;
    document.getElementById('content_top').innerHTML = gen_content_top;
}

function show_eu() 
{
    var gen_content = "";

    for (let i = 0; i < user_list.length; i++) 
    {
        gen_content +=`
            <div class = "userbox">
                <form action="adminPanel.php" method="POST">
                    <div class = "userbox_cell">
                        id<br/>`+user_list[i][0]+`
                        <input type="hidden" name = "edu_id" value = "`+user_list[i][0]+`">
                    </div>
                    <div class = "userbox_cell">
                        imie<br/>
                        <input type="text" name = "edu_name" value = "`+user_list[i][3]+`">
                    </div>
                    <div class = "userbox_cell">
                        nazwisko<br/>
                        <input type="text" name = "edu_surname" value = "`+user_list[i][4]+`">
                    </div>
                    <div class = "userbox_cell">
                        telefon<br/>
                        <input type="text" name = "edu_phone1" class = "userbox_cell_phone" value = "`+user_list[i][5].split("-")[0]+`" maxlength = 3 onkeypress="return isNumberKey(event);"> -
                        <input type="text" name = "edu_phone2" class = "userbox_cell_phone" value = "`+user_list[i][5].split("-")[1]+`" maxlength = 3 onkeypress="return isNumberKey(event);"> -
                        <input type="text" name = "edu_phone3" class = "userbox_cell_phone" value = "`+user_list[i][5].split("-")[2]+`" maxlength = 3 onkeypress="return isNumberKey(event);">
                    </div>
                    <div class = "userbox_cell">
                        login<br/>
                        <input type="text" name = "edu_login" class = "userbox_cell_access" value = "`+user_list[i][2]+`">
                    </div>
                    <div class = "userbox_cell">
                        typ<br/>
                        <select name = "edu_typ" value = "`+user_list[i][1]+`">`;

                        for (let j = 0; j < user_type_list.length; j++) {
                            gen_content += '<option value="' + user_type_list[j] +'" ';
                            
                            if (user_list[i][1] == user_type_list[j]) {
                                gen_content += 'selected="selected"';
                            }

                            gen_content +='>' + user_type_list[j] + '</option>';
                        }
                    
                        gen_content += `
                        </select>
                    </div>
                    <div class = "userbox_cell">
                        <input type="submit" value = "zapisz" class = "userbox_cell_button">
                    </div>
                </form>
                <div class = "userbox_cell">
                    <form action="adminPanel.php" method="POST">
                        <input type="hidden" name = "delu_id" value = "`+user_list[i][0]+`">
                        <input type="submit" value = "Usuń" class = "userbox_cell_button">
                    </form>
                </div>
                <div class = "userbox_cell">
                    <form action="adminPanel.php" method="POST">
                        <input type="hidden" name = "eduh_id" value = "`+user_list[i][0]+`">
                        nowe hasło<br/>
                        <input type="password" name = "edu_password" class = "userbox_cell_access">
                        <input type="submit" value = "Zapisz Hasło">
                    </form>
                </div>
                <div style="clear:both"></div>
            </div>`;
    }
    
    var gen_content_top = `
            <div class = "userbox_top">
                <form action="adminPanel.php" method="POST">
                    <div class = "userbox_cell">
                        imie<br/>
                        <input type="text" name = "adu_name">
                    </div>
                    <div class = "userbox_cell">
                        nazwisko<br/>
                        <input type="text" name = "adu_surname">
                    </div>
                    <div class = "userbox_cell">
                        telefon<br/>
                        <input type="text" name = "adu_phone1" class = "userbox_cell_phone" maxlength = 3 onkeypress="return isNumberKey(event);"> -
                        <input type="text" name = "adu_phone2" class = "userbox_cell_phone" maxlength = 3 onkeypress="return isNumberKey(event);"> -
                        <input type="text" name = "adu_phone3" class = "userbox_cell_phone" maxlength = 3 onkeypress="return isNumberKey(event);">
                    </div>
                    <div class = "userbox_cell">
                        typ<br/>
                        <select name = "adu_typ">`;

                        for (let i = 0; i < user_type_list.length; i++) {
                            gen_content_top += '<option value="' + user_type_list[i] + '">' + user_type_list[i] + '</option>';
                        }
                    
                        gen_content_top += `
                        </select>
                    </div>
                    <div class = "userbox_cell">
                        login<br/>
                        <input type="text" name = "adu_login" class = "userbox_cell_access">
                    </div>
                    <div class = "userbox_cell">
                        hasło<br/>
                        <input type="password" name = "adu_haslo" class = "userbox_cell_access" >
                    </div>
                    <div class = "userbox_cell">
                        <input type="submit" value = "Dodaj" class = "userbox_cell_button">
                    </div>
                </form>
                <div style="clear:both"></div>
            </div>`;

    if (gen_content == "") 
    {
        gen_content = '<b><span style = "font-size: 20px;">Brak Użytkowników !!! - dodaj ADMINA !!!</span></b>';
    }

    document.getElementById('content').innerHTML = gen_content;
    document.getElementById('content_top').innerHTML = gen_content_top;
}

function show_et() 
{
    var gen_content = `
            <div class = "type_box">
                Typy Zasobów<br/>
                <form action="adminPanel.php" method="POST">
                    <input type="text" name = "adit_name">
                    <input type="submit" value = "Dodaj">
                </form>`;

        for (let i = 0; i < item_type_list.length; i++) 
        {
            gen_content += `
                <form action="adminPanel.php" method="POST">
                    <input type="text" name = "delit_name" disabled="disabled" value = "`+item_type_list[i]+`">
                    <input type="submit" value = "Usuń">
                </form>`;
        }
        gen_content += `
            </div>
            <div class = "type_box">
                Typy Użytkowników<br/>
                <form action="adminPanel.php" method="POST">
                    <input type="text" name = "adut_name">
                    <input type="submit" value = "Dodaj">
                </form>`;

        for (let i = 0; i < user_type_list.length; i++) 
        {
            gen_content += `
                <form action="adminPanel.php" method="POST">
                    <input type="text" name = "delut_name" disabled="disabled" value = "`+user_type_list[i]+`">
                    <input type="submit" value = "Usuń">
                </form>`;
        }
        gen_content += `
            </div>
            <div style="clear:both"></div>`;


    document.getElementById('content').innerHTML = gen_content;
    document.getElementById('content_top').innerHTML = "";
}

function isNumberKey(evt){
    var charCode = (evt.which) ? evt.which : evt.keyCode
    return !(charCode > 31 && (charCode < 48 || charCode > 57));
}