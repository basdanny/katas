/*
    Given function printDigit(digit) that can print a single digit 
    Write function printNumber(number: int) that will print received number via printDigit(digit). No string manipulations allowed
*/
function printDigit(digit) {
    if (digit.toString().length !== 1)
        throw Error('printDigit invalid input: '+digit);
    process.stdout.write(digit.toString());
}


function printNumber(number) {
    if (number < 0) { 
        printDigit('-');         
        number *= -1;
    }
    
    let numberDevideByTen = number / 10 | 0;
    if (numberDevideByTen === 0) {                
        printDigit(number);
    }
    else {
        printNumber(numberDevideByTen);
        printDigit(number % 10);
    }
}


printNumber(-98765);