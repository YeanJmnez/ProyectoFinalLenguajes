function getAllOrder() {
    var request = $.ajax({
        url: "proyelenguajes-001-site1.gtempurl.com/WSRest/WSRestKitchenModule.svc/listOrder",
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

        //$.each(this.dishOrder, function () {

        //})

        newTR.appendChild(newTD1);
        newTR.appendChild(newTD2);

        $('#Order').append(newTR);
    }
};