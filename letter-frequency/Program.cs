
bool EqualizeFrequency(string word){
    var letters = new int[26];
    for(int i=0; i<word.Length; i++)
    {
        letters[((int)word[i]-97)]++;
    }
    
    var frequencies = new List<int>(); 
    for(int i=0;i<letters.Length;i++)
    {
        if( letters[i] == 0)
            continue;
        frequencies.Add(letters[i]);
    }        

    for(int i=0; i<frequencies.Count; i++){
        
        frequencies[i]--;
        if( frequencies.Where(p=> p!=0).GroupBy(p => p).Count() == 1)
            return true;
        frequencies[i]++;

    }
    return false;   
}

Console.WriteLine(EqualizeFrequency("bbac"));
// 1,1,1,2
// 1,2,2,2,2
// 1,3,3,3,3,3
// 1,1,1,1,3
// 2,2,2,2,3
// 3,3,3,3,6