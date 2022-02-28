$(document).ready(function () {
    //to allow only numberic
    $('#Contact').keypress(function (e) {
        NumericOnly(e);
    });
    $("#btn-Add").on("click", function () {
        ValidateUser();
    })
});
//to check all fields where user enter correct or not
// if not entered correct ,it will prevent to sumbit form
function ValidateUser() {
    event = event || window.event || event.srcElement;
    var return_val = true;
    if ($('#ProductName').val().trim() == '') {
        $('#ProductName').next('span').show();
        return_val = false;
    } else {
        $('#v').next('span').hide();
    }
    if ($('#ProductType').val().trim() == '') {
        $('#ProductType').next('span').show();
        return_val = false;
    } else {
        $('#ProductType').next('span').hide();
    }
    if ($('#Hdd').val().trim() == '') {
        $('#Hdd').next('span').text('Please enter Hard Disk Size').show();
        return_val = false;
    } else {
        $('#Hdd').next('span').hide();
        if (fnValidateHdd($('#Hdd').val().trim()) == false) {
            $('#Hdd').next('span').text('Please enter valid HDD').show();
            return_val = false;
        } else {
            $('#Hdd').next('span').text('Please enter Hard Disk Size').hide();
        }
    }
    if ($('#Ram').val().trim() == '') {
        $('#Ram').next('span').show();
        return_val = false;
    } else {
        $('#Ram').next('span').hide();
        if (PasswordStrengthCheck($('#Ram').val().trim()) == false) {
            return_val = false;
        }
    }
    if ($('#Contact').val().trim() == '') {
        $('#Contact').next('span').show();
        return_val = false;
    } else {
        $('#Contact').next('span').hide();
    }
    if ($(".field-validation-valid.text-danger").is(":visible")) {
        event.preventDefault();
    }
    else {
        $("#formCreate").submit();
    }
}
// to check password strength
function RamStrengthCheck(ram) {
    var return_val = true;
    if (ram != '') {
        if (ram.length > 5) {
            $('#Ram').next('span').text('Be less than 5 characters').show();
            $('#Ram').focus();
            return_val = false;
        } else if (!ram.match(/[A-Z]/)) {
            $('#Ram').next('span').text('At least one uppercase alphabet').show();
            $('#Ram').focus();
            return_val = false;
        } else if (!ram.match(/\d/)) {
            $('#Ram').next('span').text('At least one number').show();
            $('#Ram').focus();
            return_val = false;
        
        } else {
            $('#Ram').next('span').text('').hide();
        }
    } else {
        $('#Ram').next('span').text('Please enter RAM').show();
        return_val = false;
    }
    return return_val;
};
// to check email formate
function fnValidateHdd(hdd) {

    varexpr = /^[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]?)$/;
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
