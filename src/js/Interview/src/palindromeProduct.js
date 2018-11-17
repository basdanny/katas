/*
    Largest palindrome product
    https://learn.freecodecamp.org/coding-interview-prep/project-euler/problem-4-largest-palindrome-product/

    pro solution here: https://www.xarg.org/puzzle/project-euler/problem-4/
*/

function largestPalindromeProduct(n) {
    var maxPalindrome = -1;
    var maxNumber = Math.pow(10, n) - 1;
    var smallNumber = Math.pow(10, n-1);
    
    //console.log('max number: ' + maxNumber + ' smallNumber: '+smallNumber);

    for (var num = maxNumber; num >= smallNumber; num--) {
        for (var secNum = maxNumber; secNum >= smallNumber; secNum--) {
            //console.log('num: '+num+' secNum: '+secNum);      
            var palindrome = num * secNum;            
            if (palindrome > maxPalindrome && isPalindrome(palindrome)) {
                maxPalindrome = palindrome;
                break;
            }
            else if (palindrome < maxPalindrome) 
                break;
        }
    }

    return maxPalindrome;
}

function isPalindrome2(x) {
    var n = 0;
    var m = x;

    while (x > 0) {
        n = n * 10 + x % 10;
        x = x / 10 | 0;
    }
    return n === m;
}

function isPalindrome(number) {
    var strNumber = number + '';
    var len = strNumber.length;

    for (var i = 0; i < len / 2; i++) {
        if (strNumber[i] !== strNumber[len - 1 - i])
            return false;
    }
    return true;
}



var start = new Date().getTime();

console.log(largestPalindromeProduct(3));

var end = new Date().getTime();
var time = end - start;
console.log('Execution time: ' + time);








