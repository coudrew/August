//create empty array to add items to
var items = [];
//attach event listeners to buttons
document.getElementById('addButton').addEventListener('click', addItems, false);
document.getElementById('goButton').addEventListener('click', pickWinner, false);
//handlers
function addItems(){
    //create an array of encouraging messages so user is aware something is actually happening
    var messages = ["let's have another", "keep 'em coming", "you're the best at this!", "so good!", "ADD. THAT. SH17!!!", "that's the way to do it!"];
    //get the value of html input
    var addMe = document.getElementById('itemInput').value; 
    //test if input value is null/undefined
    if (addMe){
        //add to array and display message
        items.push(addMe);
        if (items.length < 8){
            document.getElementById('output').innerHTML = messages[Math.floor(Math.random() * messages.length)];
        } else {
            document.getElementById('output').innerHTML = `yeah ${items.length} is prolly enough, let's pick a winner!`;
        }
    } else {
        //alert the user they must enter some value
        document.getElementById('output').innerHTML = "While it's technically possible to add nothing, you're not really getting into the spirit here"
    }
}

function pickWinner(){
    //test if items is empty
    if (items.length > 0){
        //announce the winner
        document.getElementById('output').innerHTML = `Congratulations ${items[Math.floor(Math.random() * (items.length-1))]}! You've won.. a phone or whatever, I guess. Good job!!`;
    } else {
        //alert the user they haven't entered anything. be a jerk about it
        document.getElementById('output').innerHTML = "You gotta enter some stuff first. I was pretty clear about that"
    }
}