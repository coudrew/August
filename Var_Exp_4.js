var event2 = document.getElementById("button2");
event2.addEventListener('click', sum, false);

function sum(){
    var a = document.getElementById('input1').value, b = document.getElementById('input2').value;
    document.getElementById('demo').innerHTML = parseFloat(a) + parseFloat(b);
}