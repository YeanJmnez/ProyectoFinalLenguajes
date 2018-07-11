
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
//    $('#user').empty();

//    var newTitu = document.createElement("h3");
//    newTitu.innerHTML = "List Of Orders";
//    $('#user').append(newTitu);
//    $.each(data, function () {
//        var newLi = document.createElement("li");
//        var newInfo = document.createElement("h5");
//        newInfo.innerHTML = "Order Code: " + this.OrderCode + ". Name Client: " + this.ClientName + ". Dishes: " + this.dishOrder;
//        newLi.appendChild(newInfo);
//        var boton = document.createElement('input');
//        boton.type = 'button';
//        boton.id = 'B';
//        boton.value = 'Entregar';
//        boton.onclick = "";

//        newLi.appendChild(boton);
//        newLi.appendChild(document.createElement("hr"));

//        $('#user').append(newLi);
//    });
//};

function processAllOrder(data) {
    //$('#user').empty();

    //var newTitu = document.createElement("h3");
    //newTitu.innerHTML = "List Of Orders";
    //$('#user').append(newTitu);
    $.each(data, function () {
        var newTR = document.createElement("tr");

        switch(this.OrderState) {
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
        var boton = document.createElement('input');
        boton.type = 'button';
        boton.id = 'B';
        boton.value = 'Deliver';
        boton.onclick = "";

        newTD4.appendChild(boton);
        newTR.appendChild(newTD4);
        $('#user').append(newTR);
    });
}

function reloadSystemUsersTable() {
    setInterval(getAllSystemUsers, 1000);
}


