/*
Given an array with duplicates that are consecutive, return a distinct array
*/

function removeDuplicates(arr)  {
    const uniques = [];
    let prevItem = null;
    arr.forEach(n => {
        if (n !== prevItem) {
            uniques.push(n); 
            prevItem = n;
        }
    });
    return uniques;
}

const removeDuplicatesOneLiner = (arr) => Array.from(new Set(arr));


console.log(removeDuplicates([1,34,34,2,3,4,4,4,4,5,5,6]))
console.log(removeDuplicatesOneLiner([1,34,34,2,3,4,4,4,4,5,5,6]))
