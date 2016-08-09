var i = 1;
while (i<=10){
    document.getElementById('demo').innerHTML += i;
    document.getElementById('demo').appendChild(document.createElement('br'));
    i++;
}