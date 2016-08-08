document.getElementById('button1').addEventListener('click', countUp, false);

function countUp(){
    for (i=1;i<=50;i++){
        document.getElementById('demo').innerHTML += `${i}, `;
    }
}