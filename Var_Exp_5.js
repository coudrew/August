var event3 = document.getElementById("button3");
event3.addEventListener('click', larger, false);

function larger(){
    var a = parseFloat(document.getElementById('input1').value), b = parseFloat(document.getElementById('input2').value);
    document.getElementById('demo').innerHTML = a > b ? a : b;
}