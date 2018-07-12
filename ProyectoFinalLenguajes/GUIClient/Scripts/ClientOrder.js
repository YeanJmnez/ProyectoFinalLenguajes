var dishesCodesQuantitiesString = localStorage.getItem("clientOrderDishes");

var dishesCodesQuantitiesArray = new Array();
var dishesCodes = new Array();

$(document).ready(function () {
    for (var i = 0; i < dishesCodesQuantitiesString.length; i = i + 4) {
        var code = dishesCodesQuantitiesString[i];
        var quantity = dishesCodesQuantitiesString[i + 2];
        dishesCodesQuantitiesArray.push([code, quantity]);
        dishesCodes.push(code);
    }
    alert("LENGTH: " + dishesCodesQuantitiesArray.length);
    alert("DISHES CODES: " + dishesCodes.toString());
    GetSelectedDishes();
});

$(document).on('click', 'button.btnRemoveDish', function () {
    $(this).closest('tr').remove();
    return false;
});

function RemoveDish(code) {
    var index = dishesCodesQuantities.indexOf(code);

    dishesCodesQuantities.splice(index, 1);
    dishesCodes.splice(index, 1);

    alert(dishesCodesQuantities);
    alert(dishesCodes);
}

function GetSelectedDishes() {
    var request = $.ajax({
        url: "http://proyelenguajes-001-site1.gtempurl.com/WSClient/WSClient.svc/GetSelectedDishes?Codes=" + dishesCodes.toString(),
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
            newTd5.innerHTML = "<button class='btn btn-primary' id='btnRemoveDish'></button>";

            newTr.appendChild(newTd1);
            newTr.appendChild(newTd2);
            newTr.appendChild(newTd3);
            newTr.appendChild(newTd4);

            $('#TableOrderDishesBody').append(newTr);
        });

        $('#TotalPriceColumn').html("₡" + totalPrice);
    });

    request.fail(function () {
        alert("ERROR: Something Went Wrong!");
    });
}

function GetDishQuantity(code) {
    for (var i = 0; i < dishesCodesQuantities.length; i++) {
        if (code == dishesCodesQuantities[i][0]) {
            return dishesCodesQuantities[i][1];
        }
    }
}