//instantiate a Calculator object and init
var calculator = new Calculator();
calculator.init();

//get ahold of buttons and put them in an array
var numButtons = document.getElementsByClassName("btnNumber");
var numButtonsArray = Array.prototype.slice.call(numButtons);
var funcButtons = document.getElementsByClassName("btnFunc");
var funcButtonsArray = Array.prototype.slice.call(funcButtons);
var operatorButtons = document.getElementsByClassName("btnOperator");
var operatorButtonsArray = Array.prototype.slice.call(operatorButtons);

//attach event listeners to buttons
numButtonsArray.forEach(function(el){el.addEventListener("click", function(event){calculator.updateDisplay(event.target.innerText)})});
funcButtonsArray.forEach(function(el){el.addEventListener("click", function(event){calculator.enterFunction(event.target.innerText)})});
operatorButtonsArray.forEach(function(el){el.addEventListener("click", function(event){calculator.enterOperation(event.target.innerText)})});