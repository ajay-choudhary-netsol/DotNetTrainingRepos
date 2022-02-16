$(document).ready(function () {
    //to allow only numberic
    $('#Mobile').keypress(function (e) {
        NumericOnly(e);
    });
    $("#btn-addemployee").on("click", function () {
        ValidateUser();
    })
});
//to check all fields where user enter correct or not
// if not entered correct ,it will prevent to sumbit form
function ValidateUser() {
    event = event || window.event || event.srcElement;
    var return_val = true;
    if ($('#EmployeeName').val().trim() == '') {
        $('#EmployeeName').next('span').show();
        return_val = false;
    } else {
        $('#EmployeeName').next('span').hide();
    }
    if ($('#Email').val().trim() == '') {
        $('#Email').next('span').text('Please enter Email').show();
        return_val = false;
    } else {
        $('#Email').next('span').hide();
        if (fnValidateEmail($('#Email').val().trim()) == false) {
            $('#Email').next('span').text('Please enter valid Email').show();
            return_val = false;
        } else {
            $('#Email').next('span').text('Please enter Email').hide();
        }
    }

    if ($('#Mobile').val().trim() == '') {
        $('#Mobile').next('span').show();
        return_val = false;
    } else {
        $('#Mobile').next('span').hide();
    }
    if ($(".field-validation-valid.text-danger").is(":visible")) {
        event.preventDefault();
    }
    else {
        $("#formAddEmployee").submit();
    }
}
// to check email formate
function fnValidateEmail(email) {

    varexpr = /^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
    return expr.test(email);
};

function NumericOnly(e) {
    var regex = new RegExp("^[0-9]+$");
    var str = String.fromCharCode(!e.charCode ? e.which : e.charCode);
    if (regex.test(str)) {
        return true;
    }
    e.preventDefault();
    return false;
};
