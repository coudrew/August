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
    questionBlock.id = questionData.questionNumber; 
    question.innerHTML = `<h4>${questionData.domain}</h4><br/><span>${questionData.question}?</span>`;
    //iterate through current question's answers array to generate radio buttons and append to the form
    questionData.answers.forEach(function(answer, index){
       var currentAnswer = document.createElement('input');
        currentAnswer.type = 'radio';
        currentAnswer.checked = index > 0 ? false : true; //auto-check the first answer
        currentAnswer.name = questionData.question;
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

//check answers
function checkQuiz(){
    
}
var testQuestion = new QuestionData('space', 'how much space is there', ['lots', 'none', "as much as their's time at least"],2,1);
poseQuestion(testQuestion);