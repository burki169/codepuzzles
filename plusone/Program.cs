// See https://aka.ms/new-console-template for more information
int[] PlusOne(int[] digits) 
{    
    var digitCount = digits.Length;
    int carry = 1;
    for(int i=digitCount-1;i>=0;i--)
    {   
        digits[i] += carry;
        carry = digits[i] > 9 ? 1 : 0;
        digits[i] %= 10;        
    }

    if(carry == 0) 
        return digits;
    
    var l = new List<int>(digits);
    return l.Prepend(carry).ToArray();
}

Console.WriteLine( string.Join(",", PlusOne(new int[]{9,9,9,9,9,9}) ));