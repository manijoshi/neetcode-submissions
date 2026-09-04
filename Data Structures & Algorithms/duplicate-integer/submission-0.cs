public class Solution {
    public bool hasDuplicate(int[] nums) {
        int x=0;
        HashSet<int> visited = new HashSet<int>();
        for(int i=0;i<nums.Length;i++){
            if(visited.Contains(nums[i])){
                return true;
            }
            visited.Add(nums[i]);
        }
        return false;
    }
}