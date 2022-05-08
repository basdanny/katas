/*
Given an N by N matrix of 0's and 1's where all 1's in each row come before all 0's
Find the most efficient way to return the row with the maximum number of 0's.

O(n) solution
*/


let matrix = [
    [1, 1, 1, 1],
    [1, 1, 0, 0],
    [1, 1, 1, 0],
    [0, 0, 0, 0],
];

let columnsLength = matrix[0].length;
let rowsLength = matrix.length;

let resultRowIndex = -1;
let i = 0;
let j = columnsLength - 1;

while (i < rowsLength && j >= 0) {
    if (matrix[i][j] == 0) {
        j--;
        resultRowIndex = i;
    }
    else {
        i++;
    }
}

console.log(resultRowIndex);
