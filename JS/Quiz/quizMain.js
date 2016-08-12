//initialize game
document.getElementById('checkQuizBtn').addEventListener('click', checkQuiz, false);
document.getElementById('playAgainBtn').addEventListener('click', playAgain, false);
var game = new Game();
var currentQuestions = [];
populate();

//constructor to create a Game object to track score and other data
function Game(){
    this.state = 'playing';
    this.score = 0;
    this.incorrectAnswers = [];
    this.updateScore = function(value){
        this.score += value;
    }
}

//check answers
function checkQuiz(){
    if (game.state === 'playing'){
    currentQuestions.forEach(function(q){
        //get reference to current question html element, gather objects of class 'answer' into a node list
        var currentAnswers = document.getElementById(q.questionNumber).getElementsByClassName('answer');
        //convert node list to array, filter for element with true checked prop.
        var selectedAnswer = Array.prototype.slice.call(currentAnswers).filter(function(el){return el.checked === true})[0].value;
        //console.log(selectedAnswer, q.correctAnswer);
        selectedAnswer === q.correctAnswer && game.state === 'playing' ? game.updateScore(1) : game.incorrectAnswers.push(q);
    });
    game.state = 'gameOver';
    showScore();
    }
}

//function to re-initialize game
function playAgain(){
    document.getElementById('results').style.display = 'none';
    Array.prototype.slice.call(document.getElementById('quiz').getElementsByClassName('questionBlock')).forEach(function(el){
        document.getElementById('quiz').removeChild(el)});
    //get reference to reviewPrompt div and remove
    var reviewPrompt = document.getElementById('reviewPrompt') || null;
    if (reviewPrompt) {
        document.getElementById('results').removeChild(reviewPrompt);
    };
    document.getElementById('incorrect').style.display = 'none';
    //re-initialize game
    currentQuestions = [];
    game = new Game();
    populate();
}
