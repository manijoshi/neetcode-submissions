public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new(nums);
        int longest = 0;
        foreach(var num in set){
            if(!set.Contains(num-1)){
                int current = num;
                //ex. [2,20,4,10,3,4,5]; current = 2, length 1
                int length = 1;
                while(set.Contains(current+1)){
                    current++;
                    length++;
                }
                longest = Math.Max(longest,length);
            }
            
        }
        return longest;
    }
}
