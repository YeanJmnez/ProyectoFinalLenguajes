var dishesCodesQuantities = new Array(localStorage.getItem("clientOrderDishes"));
var dishesCodes = new Array();

$(document).ready(function () {
    alert(dishesCodes);
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
    for (var i = 0; i < dishesCodesQuantities.length; i++) {
        dishesCodes.push(dishesCodesQuantities[i][0]);
    }

    var request = $.ajax({
        url: "http://proyelenguajes-001-site1.gtempurl.com/WSClient/WSClient.svc/GetSelectedDishes?Codes=" + dishesCodes,
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