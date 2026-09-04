public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> visited = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            int complement = target-nums[i];
            if(visited.ContainsKey(complement)){
                return new int[] { visited[complement], i };
            }
            else{
                visited[nums[i]]=i;
            }
        }
        return new int[]{};
    }
}
