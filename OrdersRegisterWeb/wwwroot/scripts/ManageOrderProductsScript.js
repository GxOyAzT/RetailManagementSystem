function IncrementOrderQuantity(iterator) {
    var QuantityInput = document.getElementById("QuantityInput" + iterator);
    var actualQua = parseInt(QuantityInput.value);
    actualQua++;
    if (actualQua > 100) {
        return;
    }
    else {
        QuantityInput.value = actualQua;
        CalculateTotalForDistinctProduct(actualQua, iterator);
        CalculateTotalForWholeOrder();
    }
}

function DecrementOrderQuantity(iterator) {
    var QuantityInput = document.getElementById("QuantityInput" + iterator);
    var actualQua = parseInt(QuantityInput.value);
    actualQua--;
    console.log("XD");
    if (actualQua < 0) {
        return;
    }
    else {
        QuantityInput.value = actualQua;
        CalculateTotalForDistinctProduct(actualQua, iterator);
        CalculateTotalForWholeOrder();
    }
}

function CalculateTotalForDistinctProduct(quantity, iterator) {
    var price = parseFloat(document.getElementById('InputBoxPrice' + iterator).value);
    console.log(quantity + "  " + price);
    document.getElementById("InputTotalProductPrice" + iterator).value = String((price * quantity).toFixed(2)) + " $";
}

function CalculateTotalForWholeOrder() {
    total = 0.0;
    for (i = 0; true; i++) {
        if (document.getElementById('QuantityInput' + i) == null) {
            break;
        }
        var quantity = parseInt(document.getElementById('QuantityInput' + i).value);
        var price = parseFloat(document.getElementById('InputBoxPrice' + i).value);
        total += quantity * price;
        console.log(quantity.toString() + " " + price.toString() + " " + total.toString());
    }
    document.getElementById('InputOrderTotal').value = String(total.toFixed(2)) + " $";
}