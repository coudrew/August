//Variables and expressions - ex3 - take user input and display it on the page

var event1 = document.getElementById("button1");
event1.addEventListener('click', myFirst, false);

var event2 = document.getElementById("button2");
event2.addEventListener('click', sum, false);

var event3 = document.getElementById("button3");
event3.addEventListener('click', larger, false);

var event4 = document.getElementById("button4");
event4.addEventListener('click', sameOrDiff, false);

function myFirst(){
    var userInput1 = document.getElementById('input1').value;
    
    document.getElementById("demo").innerHTML = userInput1;
}
function sum(){
    var a = document.getElementById('input1').value, b = document.getElementById('input2').value;
    document.getElementById('demo').innerHTML = parseFloat(a) + parseFloat(b);
}
function larger(){
    var a = parseFloat(document.getElementById('input1').value), b = parseFloat(document.getElementById('input2').value);
    document.getElementById('demo').innerHTML = a > b ? a : b;
}
function sameOrDiff(){
    var a = parseFloat(document.getElementById('input1').value), b = parseFloat(document.getElementById('input2').value);
    document.getElementById('demo').innerHTML = a === b ? "Same" : "Different";
}