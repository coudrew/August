function Calculator(){
    this.displayState = 0;
    this.displayOutput = "0";
    this.leftOperand = "";
    this.rightOperand = "";
    this.opState = 0;
    this.currentOperator = "";
    this.operations = [];
    this.output = 0;
    
    this.updateDisplay = function(data){
        
        //check if data should replace current displayOut or add to it. 
        if (this.displayState == 0){
            //check if input is a decimal point and add leading zero if so
            if (data == "."){
                this.displayOutput = `0${data}`;
            } else {
            this.displayOutput = data;
            }
            this.displayState = 1;
        } else if (this.displayState == 1){
            //check if data is decimal point and only add to displaOutput is there is currently no decimal point
            if (data == "."){
                this.displayOutput += /\./.test(this.displayOutput) ? "" : data;
            } else {
                this.displayOutput += data;
            }
            
        }
        //stuff displayOut into screen
        document.getElementById("lblDisplayScreen").innerText = this.displayOutput;
    }
    
    this.enterFunction = function(data){
        switch (data){
            case "C":
                this.leftOperand = "0";
                this.rightOperand = "0";
                this.displayOutput = "0"; //set output to 0
                this.displayState = 0; //set state to replace output
                this.updateDisplay(this.displayOutput); //update display output
                this.displayState = 0; //return to state 0 (avoid leading zeroes, looks bad)
                this.output = 0;
                break;
            case "+/-":
                this.displayOutput = /-/.test(this.displayOutput) ? this.displayOutput.substring(1) : "-" + this.displayOutput; //attach or remove minus sign
                this.displayState = 0; //set state to replace output
                this.updateDisplay(this.displayOutput); //update display output
                break;
            default:
                break;
        }
    }
    
    this.enterOperation = function(data){
        if (data == "="){
            this.rightOperand = this.displayOutput;
            this.processOperations();
            this.opState = 0;
        } else {
            this.currentOperator = data;
            this.displayState = 0;
            if (this.opState == 0){
                this.leftOperand = this.displayOutput;
                this.opState = 1;
            } else {
                this.rightOperand = this.displayOutput;
                this.processOperations();
                this.leftOperand = this.output.toString();
                this.displayState = 0;
            }
            //this.opState == 0 ? this.leftOperand = this.displayOutput : this.rightOperand = this.displayOutput;
            //this.opState = 1;
        }
        console.log(`left: ${this.leftOperand}, right: ${this.rightOperand}, op: ${this.currentOperator}`);
    }
    
    this.processOperations = function(){
        this.output = 0;
        switch (this.currentOperator){
            case "+":
                this.output = parseFloat(this.leftOperand) + parseFloat(this.rightOperand);
                break;
            case "-":
                this.output = parseFloat(this.leftOperand) - parseFloat(this.rightOperand);
                break;
            case "/":
                this.output = parseFloat(this.leftOperand) / parseFloat(this.rightOperand);
                break;
            case "*":
                this.output = parseFloat(this.leftOperand) * parseFloat(this.rightOperand);
                break;
            case "%":
                this.output = parseFloat(this.leftOperand) % parseFloat(this.rightOperand);
                break;
            default:
                break;
        }
        //this.opState = 0;
        this.displayState = 0;
        this.updateDisplay(this.output.toString());
    }
    
    this.init = function(){
        this.updateDisplay(0);
        this.displayState = 0;
    }
}
