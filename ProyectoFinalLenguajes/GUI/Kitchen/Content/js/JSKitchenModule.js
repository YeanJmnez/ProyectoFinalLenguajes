function getAllOrder() {
    var request = $.ajax({
        url: "/WSRest/WSRestKitchenModule.svc/listOrder",
        timeout: 10000,
        datatype: "json"
    });

    request.done(function (data) {
        processGetAllSystemUserData(data);
    });

    request.fail(function () {
        alert("ERROR: Something went wrong!");
    });
}

function processAllOrder(data) {
    for (var i = 0; i <= 10; i++) {
        var newTR = document.createElement("tr");

        var newTD1 = document.createElement("td");
        newTD1.innerHTML = this.OrderCode;
        var newTD2 = document.createElement("td");
        newTD2.innerHTML = this.ClientName;

        $.each(this.dishOrder, function () {

        })

        var newTD4 = document.createElement("td");
        newTD4.innerHTML = this.OrderCode;
        var newTD5 = document.createElement("td");
        newTD5.innerHTML = this.OrderState;
        var newTD6 = document.createElement("td");
        newTD6.innerHTML = this.TotalPrice;

     

        newTR.appendChild(newTD1);
        newTR.appendChild(newTD2);
        newTR.appendChild(newTD3);

        $('#tbSystemUser').append(newTR);
    }
};