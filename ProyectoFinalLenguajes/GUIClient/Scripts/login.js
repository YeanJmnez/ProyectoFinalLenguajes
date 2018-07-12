$(document).ready(function () {
    $('#txtLoginUserEmail').keyup(function () {
        if ($(this).val() == "") {
            $('#wrongUserName').addClass('hidden');
            $('#loginEmptyUserName').removeClass('hidden');
        } else {
            $('#loginEmptyUserName').addClass('hidden');
            $('#wrongUserName').addClass('hidden');
        }
    }),
    $('#txtLoginUserPassword').keyup(function () {
        if ($(this).val() == "") {
            $('#wrongPassword').addClass('hidden');
            $('#loginEmptyPassword').removeClass('hidden');
        } else {
            $('#loginEmptyPassword').addClass('hidden');
            $('#wrongPassword').addClass('hidden');
        }
    });
});

function checkTextBoxes() {
    var userEmail = document.getElementById('txtLoginUserEmail').value;
    var userPassword = document.getElementById('txtLoginUserPassword').value;

    console.log(userEmail);
    console.log(userPassword);

    if (userEmail == '') {
        $('#loginEmptyUserName').removeClass('hidden');
    }
    if (userPassword == '') {
        $('#loginEmptyPassword').removeClass('hidden');
    }

}

function UserLogin() {
    var userEmail = document.getElementById("txtLoginUserEmail");
    var userPassword = document.getElementById("txtLoginUserPassword");

    var request = $.ajax({
        url: "http://proyelenguajes-001-site1.gtempurl.com/WSClient/WSClient.svc/UserLoginValidation?email="
            + userEmail + "&password=" + userPassword,
        timeout: 10000,
        datatype: "jsonp"
    });

    request.done(function (data) {
        var length = data.length;
        alert(length);

        $.each(data, function () {

        });
    });

    request.fail(function () {
        alert("ERROR");
    });
}