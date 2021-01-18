/*
    Swap numbers in place without temporary variables
*/


function swapNumbers(x, y) {
    x = x + y;
    y = x - y;
    x = x - y;

    return [x, y];
}

let x = 10
let y = -30;
console.log(`x: ${x} y: ${y}`);
[x, y] = swapNumbers(x, y);
console.log(`x: ${x} y: ${y}`);
