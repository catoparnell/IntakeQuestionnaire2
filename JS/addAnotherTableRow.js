jQuery(function () {
    var counter = 1;
    jQuery('a.add-author').click(function (event) {
        event.preventDefault();
        counter++;
        var newRow = jQuery('<tr><td><input type="text" name="first_name' +
            counter + '"/></td><td><input type="text" name="last_name' +
            counter + '"/></td></tr>');
        jQuery('table.gg').append(newRow);
    });
});