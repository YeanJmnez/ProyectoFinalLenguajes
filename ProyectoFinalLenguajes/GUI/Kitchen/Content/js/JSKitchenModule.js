
$(document).ready(function () {
    getAllOrder();
});

setInterval(getAllOrder, 1000);


function getAllOrder() {
    var request = $.ajax({
        url: "http://proyelenguajes-001-site1.gtempurl.com/WSRest/WSRestKitchenModule.svc/ListKitchenModule",
        timeout: 10000,
        datatype: "jsonp"
    });

   
    request.done(function (data) {
        processAllOrder(data);
        getQuantity();
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
                newTR.classList.add("success");
                break;
            case "Sobre Tiempo":
                newTR.classList.add("warning");
                break;
            default:
                newTR.classList.add("danger");
                break;
        }

        var newTD1 = document.createElement("td");
        newTD1.innerHTML = this.OrderCode;
        var newTD2 = document.createElement("td");
        newTD2.innerHTML = this.ClientName

        var newTD = document.createElement("td");
        newTD.innerHTML = this.OrderDate

        var newTD3 = document.createElement("td");
        newTD3.innerHTML = this.dishOrder;

        newTR.appendChild(newTD1);
        newTR.appendChild(newTD2);
        newTR.appendChild(newTD);
        newTR.appendChild(newTD3);

        var newTD4 = document.createElement("td");
        var boton = "<button class='btn btn-primary' onclick='changeDeliver(" + this.OrderCode + ", \"" + this.OrderState + "\")'>Deliver</button>";

        newTD4.innerHTML = boton;
        newTR.appendChild(newTD4);
        $('#user').append(newTR);
    });
}

function getQuantity() {
    var request = $.ajax({
        url: "http://proyelenguajes-001-site1.gtempurl.com/WSRest/WSRestKitchenModule.svc/QuantityOrders",
        timeout: 10000,
        datatype: "jsonp"
    });
    document.getElementById("L_Quantity").innerHTML = "Existen un total de: " + request + " ordenes.";
}

function changeDeliver(orderCode, stateOrder) {
    var request = $.ajax({
        url: "http://proyelenguajes-001-site1.gtempurl.com/WSRest/WSRestKitchenModule.svc/ChangeStateOrder?OrderCode=" + orderCode + "&state=Entregado",
        timeout: 10000,
        datatype: "jsonp"
    });
    localStorage.setItem("undo", orderCode);
    localStorage.setItem("status", stateOrder);
}

function UndoDeliver() {
    var request = $.ajax({
        url: "http://proyelenguajes-001-site1.gtempurl.com/WSRest/WSRestKitchenModule.svc/ChangeStateOrder?OrderCode=" + localStorage.getItem("undo") + "&state=" + localStorage.getItem("status"),
        timeout: 10000,
        datatype: "jsonp"
    });
}


