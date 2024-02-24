/**
 * @param {string} s
 * @return {number}
 */
var _ = require('lodash');

const maxSignedInt = Math.pow(2,31)-1;
const minSignedInt = -(maxSignedInt+1);
var myAtoi = function(s) {
  let num = _.trimStart(s);
  let negative = num.charAt(0) === '-';
  if(negative){
    num = num.substring(1);
  } 
  let value = "";
  for(let i=0;i<num.length;i++){
    let ch = num.charAt(i);
    if(!Number.isInteger(ch)){
        break;
    }    
    value= value+ch;
  }
  console.log(value)
};

const tests = ["42","  0042", " -42", "5748579", ""];
_.forEach(tests, val => myAtoi(val));
