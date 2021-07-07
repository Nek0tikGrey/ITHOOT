﻿$(document).ready(
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
        return false;
    } catch (ex) {
        console.log(ex);
    }
}

function sendAjaxForm( ajax_form, url) {
    $.ajax({
        url: url, 
        type: "POST", 
        dataType: "html",
        data: $("#" + ajax_form).serialize(), 
        success: function (response) { 
            result = $.parseJSON(response);
            $('#main').html(response);
        },
        error: function (response) {
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
