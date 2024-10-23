// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function performCalc() {
    var answer; 
    var worked = document.getElementsByName('hWorked')[0].value;
    var rate = document.getElementsByName('hRate')[0].value;

    answer = parseFloat(worked) * parseFloat(rate);

    document.getElementById('hAnswer').value = answer;
}