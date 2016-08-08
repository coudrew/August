document.getElementById('button1').addEventListener('click', sumThese, false);

function sumThese(){
    document.getElementById('demo').innerHTML = document.getElementById('input').value.split(',').reduce((a,b)=> parseInt(a) + parseInt(b));
}