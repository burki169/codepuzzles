using System.Diagnostics;

int findIndexBinarySearch(int[] nums, int target){        
    int hi = nums.Length;    
    if(hi == 0)
        return -1;
    if(nums[0] == target)
        return 0;

    int lo = 0;

    int mid = (int) Math.Floor((double)nums.Length/2);
    while(mid<hi && mid>lo){
        if(nums[mid] == target)
            return mid;
        if(nums[mid]<target){
            lo = mid;
            mid = mid+(int)Math.Floor((double)(hi-mid)/2);            
        }
        else{
            hi = mid;
            mid = lo+(int)Math.Floor((double)(mid-lo)/2);            
        }
    }
    return -1;
}
int[] SearchRangeWithLists(int[] nums, int target) {
    var numsList = new List<int>(nums);    
    var result = new int[2]{
        numsList.IndexOf(target),
        numsList.LastIndexOf(target)
    };
    return result;        
}
int[] SearchRange(int[] nums, int target) {
    
    var index = findIndexBinarySearch(nums, target);
    if( index == -1 )
        return new int[2]{-1,-1};
    var left = index;
    var right = index;
    while(left >-1 && nums[left] == target)
        left--;
    while(right<nums.Length && nums[right] == target)
        right++;
    return new int[2]{left+1,right-1};    
}
List<int> nums = new List<int>();

nums.AddRange(new int[]{1});
int target = 1;
for(int i=0; i<1000000; i++){
    nums.Add(i);
}
 target = 99859;
/*

int mid = findIndexBinarySearch(nums.ToArray(),target);
Console.WriteLine(mid);
*/
int mid = findIndexBinarySearch(nums.ToArray(),target);
//Console.WriteLine(mid);
var s = Stopwatch.StartNew();
var result = SearchRange(nums.ToArray(), target);
s.Stop();

//Console.WriteLine(s.ElapsedTicks);
Console.WriteLine(s.ElapsedMilliseconds);
Array.ForEach( result, x => Console.WriteLine(x));


