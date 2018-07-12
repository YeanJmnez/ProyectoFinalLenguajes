$(document).ready(function() {
    GetDishesList();
});
var clientOrderDishesArray = new Array();

if (localStorage.getItem("clientOrderDishes") == null) {
    localStorage.setItem("clientOrderDishes", clientOrderDishesArray);
} else {
    var orderDishesLocalStorage = localStorage.getItem("clientOrderDishes");
    for (var i = 0; i < orderDishesLocalStorage.length; i = i + 4) {
        var code = orderDishesLocalStorage[i];
        var quantity = orderDishesLocalStorage[i + 2];
        clientOrderDishesArray.push([code, quantity]);
    }
}

function GetDishesList() {
    var request = $.ajax({
        url: "http://proyelenguajes-001-site1.gtempurl.com/WSClient/WSClient.svc/DishesList",
        timeout: 10000,
        datatype: "jsonp"
    });
    request.done(function (data) {
        ProcessDishesList(data);
    });
    request.fail(function () {
        alert("ERROR: Something went wrong");
    });
}

function ProcessDishesList(data) {
    $.each(data, function () {
        var newTr = document.createElement("tr");

        var newTd1 = document.createElement("td");
        newTd1.innerHTML = this.Name;
        var newTd2 = document.createElement("td");
        newTd2.innerHTML = "₡" + this.Price;
        var newTd3 = document.createElement("td");
        newTd3.innerHTML = "<button class='btn btn-primary' onclick='ShowDishDetail(" + this.Code + ")'>More details</button>";

        newTr.appendChild(newTd1);
        newTr.appendChild(newTd2);
        newTr.appendChild(newTd3);

        $('#dishesTableBody').append(newTr);
    });
}

function ShowDishDetail(item) {
    $('#dishesListContainer').addClass('hidden');
    var request = $.ajax({
        url: "http://proyelenguajes-001-site1.gtempurl.com/WSClient/WSClient.svc/FilterDishes?Code=" + item,
        timeout: 10000,
        datatype: "jsonp"
    });
    request.done(function (data) {
        $.each(data, function () {
            var newH2 = "<h2>Dish Information</h2>";
            var newH3 = document.createElement("h3");
            var newBtn1 = "<button class='btn btn-primary' onclick='ReturnToDishesList()'>Return to Dishes List</button>"
            newH3.innerHTML = "Dish Name: " + this.Name;

            var newP = document.createElement("p");
            newP.innerHTML =
                "<strong>Description: </strong>" + this.Description + "<br />"
                + "<strong>Price: </strong> ₡" + this.Price + "<br />"
                + "<strong>Photo: </strong><br />";

            var newImg = "<img class='dish-image' src='http://proyelenguajes-001-site1.gtempurl.com/DishesPicture/" + this.Picture + "' /><br /><br />";
            
            var newBtn2 = "<button class='btn btn-primary' onclick='AddDishToOrder(" + this.Code + ")'>Add To My Order</button><br /><br />"
            
            $('#dishInformationContainer').append(newH2);
            $('#dishInformationContainer').append(newH3);
            $('#dishInformationContainer').append(newP);
            $('#dishInformationContainer').append(newImg);
            $('#dishInformationContainer').append(newBtn2);
            $('#dishInformationContainer').append(newBtn1);
            $('#dishInformationContainer').removeClass('hidden');
        });        
    });
    request.fail(function () {
        alert("ERROR: Something went wrong");
    });
}

function ReturnToDishesList() {
    $('#dishInformationContainer').empty();
    $('#dishInformationContainer').addClass('hidden');
    $('#dishesListContainer').removeClass('hidden');
}

function AddDishToOrder(code) {
    var exist = false;
    var count = 0;
    var index = 0;
    for (var i = 0; exist == false && i < clientOrderDishesArray.length; i++) {
        if (code == clientOrderDishesArray[i][0]) {
            count = clientOrderDishesArray[i][1];
            exist = true;
            index = i;
        }
    }

    count++;

    if (exist) {
        clientOrderDishesArray[index][1] = count;
    } else {
        clientOrderDishesArray.push([code, count]);
    }
    localStorage.setItem("clientOrderDishes", clientOrderDishesArray);
}