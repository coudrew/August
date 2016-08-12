//Variables and expressions - ex3 - take user input and display it on the page

var event8 = document.getElementById("button8");
event8.addEventListener('click', greaterThanTens, false);

function greaterThanTens(){
    var a = parseInt(document.getElementById('input1').value);
    var b = parseInt(document.getElementById('input2').value);
    if (a>10 || b>10){
        document.getElementById('demo').innerHTML = (a>10 && b>10 ? 'both are ' : a>10 ? 'a is ' : 'b is ') + 'greater than 10.';
    } else {
        document.getElementById('demo').innerHTML = 'neither are greater than 10';
    }
}