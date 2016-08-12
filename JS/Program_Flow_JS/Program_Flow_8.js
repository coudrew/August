for (i=1; i<=10; i++){
    document.getElementById('demo').innerHTML += `Outer loop number: ${i}`;
    document.getElementById('demo').appendChild(document.createElement('br'));
    for (j=1; j<=10; j++){
        document.getElementById('demo').innerHTML += `Inner loop number: ${j}`;
        document.getElementById('demo').appendChild(document.createElement('br'));
    }
}