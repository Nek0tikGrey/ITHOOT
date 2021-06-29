$(document).ready(
    function () {
        $("#save").click(
            function (url) {
                sendAjaxForm('ajax_edit_form', url);
                return false;
            }
        );
    }
);

postQuery = form => {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                 $('#main').html(res);
            },
            error: function (err) {
                console.log(err);
            }
        })
        //to prevent default form submit event
        return false;
    } catch (ex) {
        console.log(ex);
    }
}

function sendAjaxForm( ajax_form, url) {
    $.ajax({
        url: url, //url страницы (action_ajax_form.php)
        type: "POST", //метод отправки
        dataType: "html", //формат данных
        data: $("#" + ajax_form).serialize(),  // Сеарилизуем объект
        success: function (response) { //Данные отправлены успешно
            result = $.parseJSON(response);
            $('#main').html(response);
        },
        error: function (response) { // Данные не отправлены
            $('#main').html(response);
        }
    });
}

getRequest = (url) => {
    try {
        $.ajax({
            type: 'GET',
            url: url,
            contentType: false,
            processData: false,
            success: function (res) {
                $('#main').html(res);
            },
            error: function (err) {
                console.log(err);
            }

        });
        return false;
    } catch (ex) {
        console.log(ex);
    }
}

jQueryAjaxDelete = form => {
   try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                $('#main').html(res);
            },
            error: function (err) {
                console.log(err);
            }

        });
        return false;
    } catch (ex) {
        console.log(ex);
    }
}
