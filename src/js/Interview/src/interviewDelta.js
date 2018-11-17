/* 
    function that takes two or more arrays and returns an array of the symmetric difference (△ or ⊕) of the provided arrays
    https://learn.freecodecamp.org/coding-interview-prep/algorithms/find-the-symmetric-difference 
*/


function SymmetricDifference(args) {    
    if (!arguments.length || isNaN(arguments.length) || arguments.length < 2)
        throw 'Illegal input';
             
    var outputArr = [];
    for (var i = 0; i < arguments.length; i++) {
        var workingArr = arguments[i];
        for (var k = 0; k < arguments[i].length; k++) {

            var val = workingArr[k];
            if (!val || isNaN(val)) continue;
            
            if (workingArr.indexOf(val) < k) {//ignore repetitionms of the same number in the same array                
                continue;
            }

            var foundIndex = outputArr.indexOf(workingArr[k]);
            if (foundIndex < 0) {
                outputArr.push(workingArr[k]);
            }
            else {
                outputArr.splice(foundIndex, 1);
            }
        }
    }

    return outputArr;
}
  
  var resultArray = SymmetricDifference([1, 2, 3], [5, 2, 1, 4]);
  console.log(resultArray);  
  resultArray = SymmetricDifference([3, 3, 3, 2, 5], [2, 1, 5, 7], [3, 4, 6, 6], [1, 2, 3]);
  console.log(resultArray);  