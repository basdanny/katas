/* 
    Get a square root of a number - result should be a whole number equals or less than the square root
*/

function Sqrt(num) {
    //TODO: input validation;

    let startIndex = 1;
    let endIndex = 65005;

    //reduce range of search
    while (true) {
        let newEndIndex = startIndex + Math.round((endIndex - startIndex) / 2);
        if ((newEndIndex * newEndIndex) < num) {
            startIndex = newEndIndex;
        } else {
            endIndex = newEndIndex;
        }

        if (endIndex - startIndex < 10)
            break;
    }

    let result = startIndex * startIndex;
    let nextResult;
    for (let i = startIndex + 1; i < endIndex; i++) {
        nextResult = (i + 1) * (i + 1);
        if (result === num || (result < num && nextResult > num))
            return i;

        result = nextResult;
    }

    return NaN;
}





var start = new Date().getTime();

console.log(Sqrt(4225000000));
console.log(Sqrt(4225000001));
console.log(Sqrt(4225000002));
console.log(Sqrt(4225000003));
console.log(Sqrt(4225000004));
console.log(Sqrt(90));

var elapsed = new Date().getTime() - start;
console.log('Execution time: ' + elapsed);



