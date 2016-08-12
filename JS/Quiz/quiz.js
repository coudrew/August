//constructor for question data, accepts 3 params: domain (string), question (string), and answers (string array).
//returned object must be fed to poseQuestion to display/interact with question
function QuestionData(domain, question, answers, correctIndex, questionNumber){
    this.domain = domain;
    this.question = question;
    this.answers = answers;
    this.correctAnswer = answers[correctIndex];
    this.questionNumber = `qn${questionNumber}`;
}

//takes 1 param, a QuestionData instance, creates html and posts question to document
function poseQuestion(questionData){
    //create the html elements required
    var questionBlock = document.createElement('div');
    var question = document.createElement('p');
    var answers = document.createElement('form');
    //initialize question
    questionBlock.id = questionData.questionNumber; //id needs to match questionNumber for checkQuiz to function
    questionBlock.className = 'questionBlock col-md-3';
    question.innerHTML = `<h4>${questionData.domain}</h4><br/><span>${questionData.question}</span>`;
    //iterate through current question's answers array to generate radio buttons and append to the form
    questionData.answers.forEach(function(answer, index){
       var currentAnswer = document.createElement('input');
        currentAnswer.type = 'radio';
        currentAnswer.checked = index > 0 ? false : true; //auto-check the first answer
        currentAnswer.name = 'answer';
        currentAnswer.className = 'answer';
        currentAnswer.value = answer;
        answers.appendChild(currentAnswer);
        var answerText = document.createElement('span');
        answerText.innerHTML = answer;
        answers.appendChild(answerText);
        answers.appendChild(document.createElement('br'));
    });
    //append elements to page
    questionBlock.appendChild(question);
    questionBlock.appendChild(answers);
    document.getElementById('quiz').appendChild(questionBlock);
}

//populate the quiz
function populate(){
  //create an array to hold previously selected indices
  var pseudoRandomPrevious = [-1]; //added -1 to avoid null array errors, will not conflict with operation of p random numbers
  for (i=0; i<5; i++){
    //create random number, check against previously selected indices, recreate if necessary
    var pseudoRandom = Math.floor(Math.random() * 8);
    while (pseudoRandomPrevious.filter(function(el){return el === pseudoRandom}).length > 0){
      pseudoRandom = Math.floor(Math.random() * 8);
    }
    var currentQuestion = questionDataArray[pseudoRandom];
    //create QuestionData obj from questionDataArray,push to array of questions, post to document
    var currentQuestionData = new QuestionData(currentQuestion[0], currentQuestion[1], currentQuestion[2], currentQuestion[3], i);
    currentQuestions.push(currentQuestionData);
    poseQuestion(currentQuestionData);
    //add current pseudoRandom to array of indices
    pseudoRandomPrevious.push(pseudoRandom);
  }
}

//function to display score and correct answers in modal
function showScore(){
    var results = document.getElementById('results');
    results.style.display = 'inline-block';
    if (document.getElementById('scoreDisplay')){
        results.removeChild(document.getElementById('scoreDisplay'));
    }
    var scoreDisplay = document.createElement('h3');
    scoreDisplay.id = 'scoreDisplay';
    scoreDisplay.className = 'text-center';
    scoreDisplay.style.fontSize = '2em';
    scoreDisplay.innerHTML = game.score > 4 ? `A perfect ${game.score} out of ${currentQuestions.length}!` : `You scored ${game.score}!`;
    results.appendChild(scoreDisplay);

    if (game.incorrectAnswers.length > 0){
        var reviewPrompt = document.createElement('div');
        reviewPrompt.id = 'reviewPrompt';
        reviewPrompt.className = 'controlBtn reviewBtn text-center';
        reviewPrompt.innerHTML = '<span>Review Incorrect Answers</span>';
        reviewPrompt.addEventListener('click', showIncorrect, false);
        results.appendChild(reviewPrompt);
    }
    var incorrectAnswerIndex = 0;
    function showIncorrect(){
        console.log(incorrectAnswerIndex, game.incorrectAnswers.length);
        if (document.getElementById('scoreDisplay')){
            results.removeChild(document.getElementById('scoreDisplay'));
        }
        var incorrectDiv = document.getElementById('incorrect');
        if (document.getElementById('incorrectQuestion')){
            incorrectDiv.removeChild(document.getElementById('incorrectQuestion'));
        }
        if (document.getElementById('correctAnswer')){
            incorrectDiv.removeChild(document.getElementById('correctAnswer'));
        }
        document.getElementById('incorrect').style.display = 'inline-block';
        document.getElementById('incorrect').className = 'text-center';
        reviewPrompt.innerHTML = '<span>Next</span>';
        var incorrectQuestion = document.createElement('span');
        incorrectQuestion.innerHTML = `Q: ${game.incorrectAnswers[incorrectAnswerIndex].question}<br/>`;
        incorrectQuestion.className = 'text-center';
        incorrectQuestion.style.fontSize = '1.5em';
        incorrectQuestion.id = 'incorrectQuestion';
        var correctAnswer = document.createElement('span');
        correctAnswer.innerHTML = `A: ${game.incorrectAnswers[incorrectAnswerIndex].correctAnswer}`;
        correctAnswer.className = 'text-center';
        correctAnswer.style.fontSize = '1.5em';
        correctAnswer.id = 'correctAnswer';
        document.getElementById('incorrect').appendChild(incorrectQuestion);
        document.getElementById('incorrect').appendChild(correctAnswer);
        incorrectAnswerIndex = incorrectAnswerIndex == game.incorrectAnswers.length - 1 ? 0 : incorrectAnswerIndex + 1;
    }
    
}
