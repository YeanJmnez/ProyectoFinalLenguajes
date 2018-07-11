$(document).ready(function() {
    GetDishesList();
});
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
        alert("CODE: " + item);
        var newH2 = "<h2>Dish Information</h2>";
        var newH3 = document.createElement("h3");
        var newBtn = "<button class='btn btn-primary' onclick='ReturnToDishesList()'>Return to Dishes List</button>"
        newH3.innerHTML = "Dish Name: " + this.Name;

        $('#dishInformationContainer').append(newH2);
        $('#dishInformationContainer').append(newH3);
        $('#dishInformationContainer').append(newBtn);
        $('#dishInformationContainer').removeClass('hidden');
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