//create an obj to hold values to post to document, with property names matching the id of elements to post to
//for ease of looping
function TaxInfo(gross, allowance, amtAt20, amtAt40, net){
    this.grossOutput = gross;
    this.allowance = allowance;
    this.amtAt20 = amtAt20;
    this.amtAt40 = amtAt40;
    this.net = net;
}
//ensure input is formatted correctly
function processInput(rawInput){
    if (/[a-z]/gi.test(rawInput)){
        alert('Numeric values only');
        return; //alert and return without doing anything if letters are supplied
    }
    return parseFloat(rawInput.split(' ').join('').split(',').join(''));//remove spaces and commas if necessary
}
//greedy algo to calculate tax and return a taxinfo obj
function calculateTaxOnAmount(amount){
    if (amount > 43000){
        var at20 = Math.floor((32000 * 0.2) * 100)/100;
        var at40 = Math.floor(((amount - 43000) * 0.4) * 100)/100; 
        return new TaxInfo(amount.toFixed(2), (11000).toFixed(2), at20.toFixed(2), at40.toFixed(2), (amount-at20-at40).toFixed(2));
    }
    if (amount > 11000){
        var at20 = Math.floor(((amount - 11000) * 0.2) * 100)/100;
        return new TaxInfo(amount.toFixed(2), (11000).toFixed(2), at20.toFixed(2), (0).toFixed(2), (amount-at20).toFixed(2));
    }
    return new TaxInfo(amount.toFixed(2), amount.toFixed(2), (0).toFixed(2), (0).toFixed(2), amount.toFixed(2));
}

//iterate through properties of taxinfo, assigning taxinfo.prop to id == prop
function appendToPage(taxInfo){
    for (prop in taxInfo){
        document.getElementById(prop).innerHTML = taxInfo[prop];
    }
}

//handler to grab current value of input field, feed calculateTaxOnAmount, and appendToPage
document.getElementById('grossBtn').addEventListener('click', processIncomeTax, false);
function processIncomeTax(){
    var grossIncome = processInput(document.getElementById('grossInput').value);
    //if grossIncome is non-null/undefined (if it passed processInput) pass to create taxinfo obj and assign, otherwise assign null
    var taxInfo = grossIncome ? calculateTaxOnAmount(grossIncome) : null;
    //if taxinfo is non-null/undefined append to the document
    if (taxInfo){
        appendToPage(taxInfo);
    }
}