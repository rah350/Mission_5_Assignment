

$('#btnSubmit').click(function () {
    var hours = $('#numHours').val();
    var rate = $('#rate').val();

    // validates number of hours
    if (hours <= 0 || isNaN(hours)) {
        alert("Please enter a valid positive number for hours. ");
        return;
    }

    // calculate the total charge
    var total = hours * rate;
    $('#total').val('$' + total.toFixed(2));
});
