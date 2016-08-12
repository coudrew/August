//helpers and init
document.getElementById('closeButton').addEventListener('click', hideModal, false);
var modalDiv = document.getElementById('outputModal');
function hideModal(){
    modalDiv.style.display = 'none';
}
//task1
document.getElementById('task1Button').addEventListener('click', takeThree, false);
function takeThree(){
    //show the output modal
    modalDiv.style.display = 'block';
    //take values from html input fields
    var a = document.getElementById('input1a').value, b = document.getElementById('input1b').value, c = document.getElementById('input1c').value;
    var arr = [a,b,c];
    document.getElementById('output').innerHTML = arr;
}

//task2
var task2arr = [];
document.getElementById('task2Button').addEventListener('click', pushAndShow, false);
function pushAndShow(){
    //show the output modal
    modalDiv.style.display = 'block';
    //push the html input value to array
    task2arr.push(document.getElementById('input2').value);
    document.getElementById('output').innerHTML = `Array contents: ${task2arr} Array length is: ${task2arr.length}`;
}    

//task 3
var task3arr = [1,2,3,4,5];
document.getElementById('task3Button').addEventListener('click', arrayMultiOp, false);
function arrayMultiOp(){
    //show the output modal
    modalDiv.style.display = 'block';
    //obtain nodelist of elements named 'arrayOp', convert to an array, filter that array for the 'checked' element, and select that element from the array
    var operation = Array.prototype.slice.call(document.getElementsByName('arrayOp')).filter(function(el){return el.checked === true})[0].value;
    var inputVal = document.getElementById('input3').value;
    document.getElementById('output').innerHTML = `Initial array contents: ${task3arr} <br/>`;
    //choose operation to carry out based on value of 'operation'
    switch (operation){
        case 'push':
            task3arr.push(inputVal);
            break;
        case 'pop':
            document.getElementById('output').innerHTML += `popping: ${task3arr.pop()} <br/>`;
            break;
        case 'unshift':
            task3arr.unshift(inputVal);
            break;
        case 'shift':
            document.getElementById('output').innerHTML += `shifting: ${task3arr.shift()} <br/>`
            break;
        
    }
    document.getElementById('output').innerHTML += `Post-operation array contents: ${task3arr}`;
}

//task4
document.getElementById('task4Button').addEventListener('click', addToArrayAtIndex, false);
var someArray = ['a','b','c','d','e','f','g','h','i','j'];
function addToArrayAtIndex(){
    //show the output modal
    modalDiv.style.display = 'block';
    document.getElementById('output').innerHTML = `Original array contents: ${someArray} <br/>`;
    //assign values of html input fields to variables
    var item = document.getElementById('input4a').value;
    var ind = parseInt(document.getElementById('input4b').value); //must be an integer to address array index
    
    someArray[ind] = item;
    document.getElementById('output').innerHTML += `Array contents after operation: ${someArray}`;
}

//task5
document.getElementById('task5Button').addEventListener('click', displayArray, false);
var showMe = [1,2,3,4,5,6,7,8,9,10];
function displayArray() {
    //show the output modal
    modalDiv.style.display = 'block';
    document.getElementById('output').innerHTML = 'Contents of array "showMe": ';
    for (i=0; i<showMe.length; i++){
        document.getElementById('output').innerHTML += `${showMe[i]} `;
    }
}

//task6
document.getElementById('task6Button').addEventListener('click', searchArray, false);
var countries = ['England', 'France', 'Italy', 'Mexico', 'Poland', 'Russia', 'China', 'Greece', 'Egypt', 'India'];
function searchArray(){
    //show the output modal
    modalDiv.style.display = 'block';
    var country = document.getElementById('input6').value;
    //create a new regex to check against array elements without case-sensitivity
    var countryReg = new RegExp(`^${country}$`, 'i');
    //assign a default 'not found' message to display if search fails
    var searchResultMSG = `${country} not found`;
    for (i=0; i<countries.length; i++){
        if (countryReg.test(countries[i])) {
            searchResultMSG = `${countries[i]} found at index: ${i}`;
            //don't waste time on the rest if we found it
            break;
        }
    }
    //display search results
    document.getElementById('output').innerHTML = searchResultMSG;
}