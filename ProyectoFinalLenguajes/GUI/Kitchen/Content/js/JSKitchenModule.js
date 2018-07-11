
$(document).ready(function () {
    getAllOrder();
});

function reloadSystemUsersTable() {
    setInterval(getAllOrder, 1000);
}

function getAllOrder() {
    var request = $.ajax({
        url: "http://localhost:12021/WSRest/WSRestKitchenModule.svc/ListKitchenModule",
        timeout: 10000,
        datatype: "jsonp"
    });

    request.done(function (data) {
        processAllOrder(data);
    });

    request.fail(function () {
        alert("ERROR: Something went wrong!");
    });
}

function processAllOrder(data) {
    $('#user').empty();
    $.each(data, function () {
        var newTR = document.createElement("tr");

        switch (this.OrderState) {
            case "A tiempo":
                newTR.style.background = "#01DF01";
                break;
            case "Sobre Tiempo":
                newTR.style.background = "#FFFF00";
                break;
            default:
                newTR.style.background = "#FF0000";
                break;
        }
        var newTD1 = document.createElement("td");
        newTD1.innerHTML = this.OrderCode;
        var newTD2 = document.createElement("td");
        newTD2.innerHTML = this.ClientName
        var newTD3 = document.createElement("td");
        newTD3.innerHTML = this.dishOrder;

        newTR.appendChild(newTD1);
        newTR.appendChild(newTD2);
        newTR.appendChild(newTD3);

        var newTD4 = document.createElement("td");
        var boton = "<button class='btn btn-primary' onclick='changeDeliver(" + this.OrderCode + ")'>Deliver</button>";

        newTD4.innerHTML = boton;
        newTR.appendChild(newTD4);
        $('#user').append(newTR);
    });
}

function changeDeliver(orderCode) {
    var request = $.ajax({
        url: "http://localhost:12021/WSRest/WSRestKitchenModule.svc/ChangeStateOrder?OrderCode=" + orderCode + "&state=Entregado",
        timeout: 10000,
        datatype: "jsonp"
    });
}


