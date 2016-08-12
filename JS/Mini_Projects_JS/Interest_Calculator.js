document.getElementById('submitButton').addEventListener('click', calculateInterest, false);

function calculateInterest(){
    var amount = parseInt(document.getElementById('amountInput').value), rate = parseInt(document.getElementById('rateInput').value), length = parseInt(document.getElementById('lengthInput').value);
    var monthlyInterest = (amount * (rate/100) * (length/12
                                                 ))/12;
    var totalInterest = monthlyInterest * length;
    document.getElementById('output').innerHTML = `Interest charged is £${monthlyInterest.toFixed()} per month, and £${totalInterest.toFixed()} in total.`;
}