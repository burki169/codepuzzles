public class Solution {
    public int MyAtoi(string s) {
        var sx = s.TrimStart();
var digits = new List<char>();         
        foreach(char c in sx){
             if(digits.Count == 0 && Char.IsWhiteSpace(c))    
                continue;
            if(digits.Count == 0 && (c == '-' || c =='+'))
            {                 
                digits.Add(c);             
                continue;
            }
                
            if(Char.IsDigit(c))
                digits.Add(c);
            else
                break;
        }
        if(digits.Count == 0 || (digits.Count == 1 && "+-".Contains(digits[0])))
            return 0;
        var val = BigInteger.Parse(digits.ToArray<char>());
        if(val <= Int32.MinValue)
            return Int32.MinValue;
        if(val >= Int32.MaxValue)
            return Int32.MaxValue;        
        return (int)val;
    }
}