var event5 = document.getElementById("button5");
event5.addEventListener('click', higherLower, false);

function higherLower(){
    var num = parseInt(document.getElementById('input1').value);
    console.log('clicked');
    document.getElementById('demo').innerHTML = `${num - 1}, ${num + 1}`;
}