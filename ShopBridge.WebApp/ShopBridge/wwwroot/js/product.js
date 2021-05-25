$(document).ready(function () {
    $('#product-table').DataTable({
        lengthChange: false,
        paging: true,
        bInfo: false,
        ordering: true
    });

    $.mask.definitions['d'] = '[0-9.]';
    $.mask.definitions['e'] = '[0-9]';
    $("#ProductInfoData_Quantity").mask("9?eeeeee");
    $("#ProductInfoData_MRPRate").mask("9?dddddddd");
    $("#ProductInfoData_SellingPrice").mask("9?dddddddd");

});

function ValidateAndSubmitProductForm() {
    $("#ProductInfoData_Name").val($("#ProductInfoData_Name").val().trim());
    $("#ProductInfoData_Description").val($("#ProductInfoData_Description").val().trim());
    var form = $('#productEditor-form');
    $.validator.unobtrusive.parse(form);
    var validator = form.data('validator');
    validator.settings.ignore = "";
    if (form.valid()) {
        form.submit();
    }
}