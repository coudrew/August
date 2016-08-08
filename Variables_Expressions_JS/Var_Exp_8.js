var event6 = document.getElementById("button6");
event6.addEventListener('click', productAndSum, false);

function productAndSum(){
    var a = parseInt(document.getElementById('input1').value);
    var b = parseInt(document.getElementById('input2').value);
    var c = parseInt(document.getElementById('input3').value);
    
    document.getElementById('demo').innerHTML = `(a+b)*c = ${(a+b)*c}, a+b+c = ${a+b+c}`;
}