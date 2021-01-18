/*
    Given an array of numbers, find the length of the longest increasing not contiguous subsequence
*/

function LongestSubsequence(arr) {
    let cache = new Array(arr.length).fill(1);

    for (let i = 1; i < arr.length; i++) {
        for (let j = 0; j < i; j++) {
            if (arr[j] < arr[i]) {
                cache[i] = Math.max(cache[i], cache[j] + 1);
            }
        }
    }

    return Math.max(...cache);
}

let arr = [7, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15];
console.log(LongestSubsequence(arr));
