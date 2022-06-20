/**
 * @param {number} num
 * @return {string}
 */
const romanMapping={
    1000 : "M",
    900 : "CM",
    500 : "D",
    400 : "CD",                    
    100 : "C",    
    90 : "XC",    
    50 : "L",    
    40 : "XL",
    10 : "X",
    9 : "IX",
    5 : "V",
    4 : "IV",
    1 : "I"
};

const romanMappingArray = Object.keys(romanMapping).map(val => parseInt(val,10)).reverse();

var intToRomanRecursive = (num,T) =>{
    if(num < T)
        return intToRomanRecursive(num, T/10);            
    if( romanMapping[num] !== undefined)    
        return romanMapping[num];
    let idx = romanMappingArray.find(key => key<= num);
    if( idx === undefined)
        return '';        
    return romanMapping[idx]+intToRomanRecursive(num-idx,T);    
}
var intToRoman = function(num) {
    return intToRomanRecursive(num,1000);
};

let num = 3999;
console.log( intToRoman(num));
