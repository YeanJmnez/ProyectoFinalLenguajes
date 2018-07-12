function UserSignUp() {
    var userEmail = document.getElementById("txtUserEmail").value;
    var userName = document.getElementById("txtUserName").value;
    var userAddress = document.getElementById("txtUserAddress").value;
    var userPassword = document.getElementById("txtUserPassword").value;

    var request = $.ajax({
        url: "http://proyelenguajes-001-site1.gtempurl.com/WSClient/WSClient.svc/AddNewWSClient?email="
            + userEmail 
            + "&name=" + userName 
            + "&address=" + userAddress 
            + "&password=" + userPassword,
        timeout: 10000
    });

    request.done(function () {
        $('#registration-form-container').addClass('hidden');
        $('#success-registration-message').removeClass('hidden');
    });

    request.fail(function () {
        alert("ERROR");
    });
}