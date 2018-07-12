var dishesCodesQuantitiesString = localStorage.getItem("clientOrderDishes");
var userEmailString = localStorage.getItem("UserEmail");
var dishesCodesQuantitiesArray = new Array();
var dishesCodesArray = new Array();

$(document).ready(function () {
    alert(userEmailString);
    if (dishesCodesQuantitiesString != null || userEmailString != null) {
        for (var i = 0; i < dishesCodesQuantitiesString.length; i = i + 4) {
            var code = dishesCodesQuantitiesString[i];
            var quantity = dishesCodesQuantitiesString[i + 2];
            dishesCodesQuantitiesArray.push([code, quantity]);
            dishesCodesArray.push(code);
        }
    }
    if (dishesCodesArray.length == 0 || userEmailString == null) {
        $('#btnSendOrder').prop("disabled", true);
    } else {
        $('#btnSendOrder').prop("disabled", false);
    }
    GetSelectedDishes();
});

function RemoveDish(code) {
    //$('#btnRemoveDish').parent().parent().remove();

    var index = dishesCodesArray.indexOf(code);

    dishesCodesQuantitiesArray.splice(index, 1);
    dishesCodesArray.splice(index, 1);

    $('#TableOrderDishesBody').empty();
    GetSelectedDishes();
}

function GetSelectedDishes() {
    var request = $.ajax({
        url: "http://proyelenguajes-001-site1.gtempurl.com/WSClient/WSClient.svc/GetSelectedDishes?Codes=" + dishesCodesArray.toString(),
        timeout: 10000,
        datatype: "jsonp"
    });

    request.done(function (data) {
        var totalPrice = 0;

        $.each(data, function () {
            var newTr = document.createElement("tr");

            var newTd1 = document.createElement("td");
            newTd1.innerHTML = this.Name;
            var newTd2 = document.createElement("td");
            newTd2.innerHTML = this.Description;
            var newTd3 = document.createElement("td");

            var quantity = GetDishQuantity(this.Code);
            var subTotal = this.Price * quantity;
            totalPrice = totalPrice + subTotal;

            newTd3.innerHTML = quantity;
            var newTd4 = document.createElement("td");
            newTd4.innerHTML = subTotal;
            var newTd5 = document.createElement("td");
            newTd5.innerHTML = "<button class='btn btn-primary' id='btnRemoveDish' onclick='RemoveDish(" + this.Code + ")'>Remove</button>";

            newTr.appendChild(newTd1);
            newTr.appendChild(newTd2);
            newTr.appendChild(newTd3);
            newTr.appendChild(newTd4);
            newTr.appendChild(newTd5);

            $('#TableOrderDishesBody').append(newTr);
        });

        $('#TotalPriceColumn').html("₡" + totalPrice);

        if (dishesCodesArray.length == 0 || userEmailString == null) {
            $('#btnSendOrder').prop("disabled", true);
        } else {
            $('#btnSendOrder').prop("disabled", false);
        }
        localStorage.setItem("clientOrderDishes", dishesCodesQuantitiesArray);
    });

    request.fail(function () {
        alert("ERROR: Something Went Wrong!");
    });
}

function GetDishQuantity(code) {
    for (var i = 0; i < dishesCodesQuantitiesArray.length; i++) {
        if (code == dishesCodesQuantitiesArray[i][0]) {
            return dishesCodesQuantitiesArray[i][1];
        }
    }
}

function SendOrder() {
    
}