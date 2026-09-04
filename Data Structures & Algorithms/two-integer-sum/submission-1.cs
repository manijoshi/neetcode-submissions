public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> visited = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            int complement = target-nums[i];
            if(visited.TryGetValue(complement, out int index)){
                return new int[] { index, i };
            }
            else{
                visited[nums[i]]=i;
            }
        }
        return new int[]{};
    }
}
