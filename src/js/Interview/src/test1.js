/*
var arr1 = [4, 5];
var arr2 = [1, 2, 3, 6, 7];
//arr2 = [...arr2, ...arr1];
arr2.splice(3, 0, ...arr1);
//arr2.splice.apply(arr2, [3, 0].concat(arr1));
console.log(arr2);


let map = new Map([[1,3],['4','5']]);
console.log(map);
console.log(map.size);

// get base logarithm of n 
function log(n, base) {  
  base = base || 10;
  return (Math.log(n) / Math.log(base)).toFixed(2);
}
console.log( log(8, 10) );  
//=> 2.9999999999999996 

var sum = [0, 1, 2, 3, 4].reduce(function (accumulator, currentValue, currentIndex, array) {
  console.log(`accumulator: ${accumulator}   currentValue:  ${currentValue}   currentIndex:  ${currentIndex}`);
  
  return accumulator + currentValue;
}, 10);
*/

let arr = [];
let promise = new Promise(function(resolve, reject) {
  setTimeout(() => {
      console.log('resolving1');
      arr.push(1);
      resolve("done!");      
    }, 2000);
});

// an immediately resolved promise
//let promise = new Promise(resolve => resolve("done!"));
promise.then(() => {
  console.log('resolving2');
  arr.push(2);
  console.log(arr);
}); 

arr.push(3);
console.log(arr);
console.log('end');



new Promise(function(resolve, reject) {
  setTimeout(() => {
    reject(new Error("Whoops!"));
  }, 1000);
  }).catch(console.log);


  Promise.all([
    new Promise((resolve, reject) => setTimeout(() => resolve(1), 3000)), // 1
    new Promise((resolve, reject) => setTimeout(() => resolve(2), 2000)), // 2
    new Promise((resolve, reject) => setTimeout(() => resolve(3), 1000))  // 3
  ]).then(console.log)
  .then(() => {
    console.log('aaaaa');
  } );
  


  var arr1 = "john".split('');
var arr2 = arr1.reverse();
var arr3 = "jones".split('');
arr2.push(arr3);
console.log("array 1: length=" + arr1.length + " last=" + arr1.slice(0));
console.log("array 2: length=" + arr2.length + " last=" + arr2.slice(-1));
console.log(arr1);
  
