var event4 = document.getElementById("button4");
event4.addEventListener('click', sameOrDiff, false);

function sameOrDiff(){
    var a = parseFloat(document.getElementById('input1').value), b = parseFloat(document.getElementById('input2').value);
    document.getElementById('demo').innerHTML = a === b ? "Same" : "Different";
}