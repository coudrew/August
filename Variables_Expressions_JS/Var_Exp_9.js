//Variables and expressions - ex3 - take user input and display it on the page

var event7 = document.getElementById("button7");
event7.addEventListener('click', negTenPlusOrTenMin, false);

function negTenPlusOrTenMin(){
    var num = document.getElementById('input1').value;
    document.getElementById('demo').innerHTML = num < 0 ? 'negative' : num < 10 ? 'less than 10' : 'greater than 10';
}

