var show_page = "r";
var show_page_status = 0;

function start()
{
    if (show_page == "mr") 
    {
        show_mr();
    }
    else
    {
        show_r();
    }
}

function b_show_mr() 
{
    show_page = "mr";
    show_page_status = 0;
    show_mr();
}

function b_show_r() 
{
    show_page = "r";
    show_page_status = 0;
    show_r();
}

function show_mr() 
{
    var gen_content = "";
    for (let i = 0; i < my_item_list.length; i++) 
    {
        var term = my_item_list[i][5];
        term = term.split("-");

        if ((new Date(term[0],term[1],term[2])).getTime() > (new Date((new Date()).getFullYear(),(new Date()).getMonth()+1,(new Date()).getDate())).getTime()) 
        {
            term = "date_green";
        }
        else
        {
            term = "date_red";
        }

        gen_content += `
            <div class = "item_box">
                <div class = "item_box_img">
                    <img class = "item_box_img" src="`+my_item_list[i][4]+`" alt="">
                </div>
                <div class = "item_box_text">
                    <b>`+my_item_list[i][1]+`</b> : `+my_item_list[i][0]+`<br/>
                    <b>`+my_item_list[i][2]+`</b>
                    <div class = "item_box_text_desc">
                        `+my_item_list[i][3]+`
                    </div>
                </div>
                <div class = "item_box_action" id = "ret_`+my_item_list[i][0]+`">
                    <div class = "`+term+`">
                        Termin : `+my_item_list[i][5]+`
                    </div>
                    <div>
                        <form action="userPanel.php" method = "POST">
                            <input type="hidden" name = "ret_id" value = "`+my_item_list[i][0]+`">
                            <input class = "item_box_action_button3"  type="submit" value = "Zwolnij"/>
                        </form>
                    </div>
                </div>
                <div style="clear:both"></div>
            </div>`
    }

    if (gen_content == "") 
    {
        gen_content = '<b><span style = "font-size: 20px;">Brak Zarezerwowanych Zasobów</span></b>';
    }

    document.getElementById('content').innerHTML = gen_content;
    document.getElementById('content_top').innerHTML = "";
}

function show_r() 
{
    if (show_page_status == 0) 
    {
        show_page_status++;

        var gen_content_top = `
            <div class = "select_item">
                Wyświetl : 
                <select id="select_type_list" class = "select_item" name="select_type_list" onchange = "select_item_type()">
                    <option value="Wszystkie">Wszystkie</option>`;

                for (let i = 0; i < item_type_list.length; i++) {
                    gen_content_top += '<option value="'+item_type_list[i]+'">'+item_type_list[i]+'</option>';
                }
                gen_content_top += `
                </select>   
            </div>`;
        document.getElementById('content_top').innerHTML = gen_content_top;
    }

    var gen_content = "";

    for (let i = 0; i < show_item_list.length; i++) 
    {
        if (show_item_list[i][5] == -1) 
        {
            gen_content += `
            <div class = "item_box">
                <div class = "item_box_img">
                    <img class = "item_box_img" src="`+show_item_list[i][4]+`" alt="">
                </div>
                <div class = "item_box_text">
                    <b>`+show_item_list[i][1]+`</b> : `+show_item_list[i][0]+`<br/>
                    <b>`+show_item_list[i][2]+`</b>
                    <div class = "item_box_text_desc">
                        `+show_item_list[i][3]+`
                    </div>
                </div>
                <div class = "item_box_action" id = "res_`+show_item_list[i][0]+`">
                    <div onclick = "reservation(`+show_item_list[i][0]+`)" class = "item_box_action_button1">Rezerwuj</div>
                </div>
                <div style="clear:both"></div>
            </div>`
        }
        else
        {
            gen_content += `
            <div class = "item_box">
                <div class = "item_box_img">
                    <img class = "item_box_img" src="`+show_item_list[i][4]+`" alt="">
                </div>
                <div class = "item_box_text">
                    <b>`+show_item_list[i][1]+`</b> : `+show_item_list[i][0]+`<br/>
                    <b>`+show_item_list[i][2]+`</b>
                    <div class = "item_box_text_desc">
                        `+show_item_list[i][3]+`
                    </div>
                </div>
                <div class = "item_box_action">
                    <div class = "item_box_action_block">
                        <b>Zablokowane</b><br/>
                        Prawdopodobnie do: `+users_block_list[show_item_list[i][5]][0]+`<br/>
                        `+users_block_list[show_item_list[i][5]][1]+` `+users_block_list[show_item_list[i][5]][2]+`<br/>
                        `+users_block_list[show_item_list[i][5]][3]+`
                    </div> 
                </div>
                <div style="clear:both"></div>
            </div>`;
        }  
    }
    document.getElementById('content').innerHTML = gen_content;
}

function b_show_zh()
{
    var gen_content = `
            <form action = "userPanel.php" method = "POST">
                <div>
                    <div class="text_password">
                        Hasło
                    </div>
                    <div class = "text_password">
                        <input type="password" class = "text_password" name = "password1" /><br />
                    </div>
                    <div style="clear:both"></div>
                </div>
                <div>
                    <div class = "text_password">
                        Powtórz Hasło
                    </div>
                    <div class = "text_password">
                        <input type="password" class = "text_password" name = "password2" /><br />
                    </div>
                    <div style="clear:both"></div>
                </div>
                <div>
                    <?php echo $passInfo ?>
                </div>
                <div>
                    <input type="submit" class = "text_password" value="Zmień">
                </div>
            </form>`;


    document.getElementById('content').innerHTML = gen_content;
    document.getElementById('content_top').innerHTML = "";
}

function select_item_type() 
{
    var selector = event.target.value;

    if (selector == 'Wszystkie') 
    {
        show_item_list = item_list;
    }
    else
    {
        show_item_list = [];

        for (let i = 0; i < item_list.length; i++) 
        {
            if (item_list[i][1] == selector) 
            {
                show_item_list.push(item_list[i]);
            }
        }
    }
    start();
}

function reservation(id_itembox_to_change) 
{
    var buff_date = new Date();

    var month = buff_date.getMonth() + 1;
    var day = buff_date.getDate() + 1;
    var year = buff_date.getFullYear();
    if (month < 10)
        month = '0' + month.toString();
    if (day < 10)
        day = '0' + day.toString();

    var buff_date = year + '-' + month + '-' + day;

    document.getElementById('res_'+id_itembox_to_change).innerHTML = `
            <form action="userPanel.php" method = "POST">
                <input class = "item_box_action_date" name = "res_date" type="date" min = "`+buff_date+`" value = "`+buff_date+`">
                <input type="hidden" name = "res_id" value = "`+id_itembox_to_change+`">
                <input class = "item_box_action_button2"  type="submit" value = "Rezerwuj"/>
            </form>`;
}