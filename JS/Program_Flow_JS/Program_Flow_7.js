var i = 1;
do {
    document.getElementById('demo').innerHTML += i;
    document.getElementById('demo').appendChild(document.createElement('br'));
    i++;
} while (i<=10);