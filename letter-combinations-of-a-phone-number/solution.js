/**
 * @param {string} digits
 * @return {string[]}
 */
let charMap = {
    "2" : "abc",
    "3" : "def",
    "4" : "ghi",
    "5" : "jkl",
    "6" : "mno",
    "7" : "pqrs",
    "8" : "tuv",
    "9" : "wxyz",
}
 var letterCombinations = function(digits) {    
    if(digits.length == 0)
        return [];            
    var digitsArray = [...digits];
    var firstChar =  digitsArray.shift();   
    var arr = [];
    for(var ch of [...charMap[firstChar]])
    {
        
        let x = letterCombinations(digitsArray.join(""));        
        if(x.length>0){
            x.forEach(element => {
                arr.push(ch+element);
            });
        }    
        else
            arr.push(ch);
    }
    return arr;
    
};

let digits = "2367"
console.log(letterCombinations(digits));