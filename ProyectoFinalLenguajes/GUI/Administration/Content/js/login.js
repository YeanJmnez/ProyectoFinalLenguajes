$(document).ready(function () {
    $('#loginUserEmail').keyup(function () {
        if ($(this).val() == "") {
            $('#wrongEmail').addClass('hidden');
            $('#loginEmptyEmail').removeClass('hidden');
        } else {
            $('#loginEmptyEmail').addClass('hidden');
            $('#wrongEmail').addClass('hidden');
        }
    }),
    $('#loginUserPassword').keyup(function () {
        if ($(this).val() == "") {
            $('#wrongPassword').addClass('hidden');
            $('#loginEmptyPassword').removeClass('hidden');
        } else {
            $('#loginEmptyPassword').addClass('hidden');
            $('#wrongPassword').addClass('hidden');
        }
    });
});

function userLogin() {
    var userEmail = document.getElementById('loginUserEmail').value;
    var userPassword = document.getElementById('loginUserPassword').value;

    console.log(userEmail);
    console.log(userPassword);

    if (userEmail == '') {
        $('#loginEmptyEmail').removeClass('hidden');
    }
    if (userPassword == '') {
        $('#loginEmptyPassword').removeClass('hidden');
    }

}