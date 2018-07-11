
$(document).ready(function () {
    getAllOrder();
});

function getAllOrder() {
    var request = $.ajax({
        url: "http://localhost:12021/WSRest/WSRestKitchenModule.svc/ListKitchenModule",
        timeout: 10000,
        datatype: "json"
    });

    request.done(function (data) {
        processAllOrder(data);
    });

    request.fail(function () {
        alert("ERROR: Something went wrong!");
    });
}

//function processAllOrder(data) {
//    $.each(data, function () {
//        var newTR = document.createElement("tr");

//        var newTD1 = document.createElement("td");
//        newTD1.innerHTML = this.OrderCode;
//        var newTD2 = document.createElement("td");
//        newTD2.innerHTML = this.ClientName;
//        var newTD3 = document.createElement("td");
//        newTD3.innerHTML = this.dishOrder;


//        //var boton = document.createElement("button");
//        //boton.type = "button";
//        //newTD4.appendChild(boton);

//        newTR.appendChild(newTD1);
//        newTR.appendChild(newTD2);
//        newTR.appendChild(newTD3);

//        $('#tbSystemUser').append(newTR);
//    })
//};

function processAllOrder(data) {
    for (var i = 0; i < 5; i++) {
        console.log('intento ' + i);
    }
};
