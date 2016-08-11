document.getElementById('task1Btn').addEventListener('click', multiCase, false);
function multiCase(){
    console.log('ping');
    var inputString = document.getElementById('task1Input').value;
    document.getElementById('task1Output').innerHTML = `Untouched: ${inputString}<br/> To Upper Case: ${inputString.toUpperCase()}<br/>To Lower Case: ${inputString.toLowerCase()}`;
}

document.getElementById('task2Btn').addEventListener('click', sliceySlicey, false);
function sliceySlicey(){
    var inputString = document.getElementById('task2Input').value;
    var inputIndex = parseInt(document.getElementById('task2Inputb').value);
    document.getElementById('task2Output').innerHTML = inputIndex < inputString.length ? `${inputString.charAt(inputIndex)}, ${inputString.slice(inputIndex)}` : 'index out of bounds';
}

function roundToNDecimal(num, n){
    return parseFloat(num.toFixed(n));
}