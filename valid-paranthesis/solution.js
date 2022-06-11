var isValid = function(s) {
    const charMap = {
        "(" : ")",
        "[" : "]",
        "{" : "}",
    }
    const p = []; 
    for(let i = 0; i < s.length; i++){
        const ch = s.charAt(i);
        if(charMap[ch] !== undefined){
            p.push(ch);
        } 
        else {            
            if(charMap[p.pop()] !== ch)
                return false;
        }
    }

    return p.length === 0;
};

const str = "[({})]"
console.log(isValid(str));