// See https://aka.ms/new-console-template for more information
bool EqualizeFrequency(string word){
    var letterFreq = new Dictionary<char,int>();

    for(int i=0; i<word.Length; i++)
    {
        if( letterFreq.ContainsKey(word[i]) )
            letterFreq[word[i]]++;
        else
            letterFreq.Add(word[i], 1);
    }

    int sum = 0;
    var values = letterFreq.Values.ToArray();
    for(int i=0;i<values.Length-2;i++)
    {
        sum += values[i] - values[i+1];
    }

    return sum == 1 || sum == -1;
    
}

Console.WriteLine(EqualizeFrequency("abccdd"));
