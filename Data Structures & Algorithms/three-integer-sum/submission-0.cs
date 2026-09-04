public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length;
        List<List<int>> result = new List<List<int>>();
        for(int i=0;i<n-2;i++){
            if(i>0 && nums[i]==nums[i-1]) continue;
            for(int j=i+1;j<n-1;j++){
                if(j>i+1 && nums[j]==nums[j-1]) continue;
                for(int k=j+1;k<n;k++){
                    if(k>j+1 && nums[k]==nums[k-1]) continue;
                    if((nums[i]+nums[j]+nums[k])==0)
                        result.Add([nums[i], nums[j], nums[k]]);
                }
            }
        }
        return result;
    }
}
