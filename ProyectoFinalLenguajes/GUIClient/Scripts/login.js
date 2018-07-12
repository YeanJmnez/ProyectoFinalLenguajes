$(document).ready(function () {
    $('#txtLoginUserEmail').keyup(function () {
        if ($(this).val() == "") {
            $('#wrongCredentials').addClass('hidden');
            $('#loginEmptyUserName').removeClass('hidden');
        } else {
            $('#loginEmptyUserName').addClass('hidden');
            $('#wrongCredentials').addClass('hidden');
        }
    }),
    $('#txtLoginUserPassword').keyup(function () {
        if ($(this).val() == "") {
            $('#wrongCredentials').addClass('hidden');
            $('#loginEmptyPassword').removeClass('hidden');
        } else {
            $('#loginEmptyPassword').addClass('hidden');
            $('#wrongCredentials').addClass('hidden');
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
    var userEmail = document.getElementById("txtLoginUserEmail").value;
    var userPassword = document.getElementById("txtLoginUserPassword").value;
    var emptyData = false;

    if (userEmail == '') {
        $('#loginEmptyUserName').removeClass('hidden');
        emptyData = true;
    }
    if (userPassword == '') {
        $('#loginEmptyPassword').removeClass('hidden');
        emptyData = true;
    }

    if (!emptyData) { 
        var request = $.ajax({
            url: "http://proyelenguajes-001-site1.gtempurl.com/WSClient/WSClient.svc/UserLoginValidation?email="
                + userEmail + "&password=" + userPassword,
            timeout: 10000,
            datatype: "jsonp"
        });

        request.done(function (data) {
            if (data.length == 0) {
                $('#wrongCredentials').removeClass('hidden');
            } else {
                $.each(data, function () {
                    alert(this.ClientEmail);
                    localStorage.setItem("UserEmail", this.ClientEmail);
                });
            }
        });

        request.fail(function () {
            alert("ERROR");
        });
    }
}