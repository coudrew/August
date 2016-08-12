var secretNumber = Math.floor((Math.random() * 10) + 1), guessCount = 0;
document.getElementById('guessButton').addEventListener('click', checkGuess, false);

function checkGuess(){
    var guess = parseInt(document.getElementById('guessInput').value);
    guessCount++;
    if (guess){
        document.getElementById('output').innerHTML = guess === secretNumber ? `Well done! You correctly guessed ${secretNumber} in ${guessCount} guesses!` :
        guess > secretNumber ? 'Too high!' : 'Too Low!';
    } else {
        document.getElementById('output').innerHTML = 'You must enter a guess!'
    }
}