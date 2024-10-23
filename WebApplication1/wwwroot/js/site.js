// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function performCalc() {
    var answer; 
    var worked = document.getElementsByName('HoursWorked')[0].value;
    var rate = document.getElementsByName('HourlyRate')[0].value;

    answer = parseFloat(worked) * parseFloat(rate);

    document.getElementById('hAnswer').value = answer;
}

const uploadField = document.getElementById("file");

uploadField.onchange = function () {
    if (this.files[0].size > 1048576) { 
        alert("File must be 1mb or less");
        this.value = ""; 
    }
};