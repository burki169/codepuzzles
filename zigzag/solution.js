/**
 * Zigzag Conversion
 * 
 * The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: 
 * (you may want to display this pattern in a fixed font for better legibility)
 * P   A   H   N
 * A P L S I I G
 * Y   I   R
 * 
 * And then read line by line: "PAHNAPLSIIGYIR"
 * 
 */

const convert = function(s, numRows) {
    if(numRows>=s.length || numRows == 1)
        return s;

    let increment = -1;
    let index = 0;
    let result= Array(numRows).fill("");

    for(var i=0; i<s.length; i++){
        if(i%(numRows-1) == 0 || index==0)
            increment *= -1;
        result[index] += s[i];        
        index += increment;                
    }     
    return result.join('');
};

const input = "OSMANNAROTER,FORKIFORKI";
const output = convert(input,3);
console.log(output);