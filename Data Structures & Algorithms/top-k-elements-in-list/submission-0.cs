public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> freq = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            freq[nums[i]] = freq.GetValueOrDefault(nums[i])+1;
        }
        var sorted = freq.OrderByDescending(x => x.Value).ToList();
        int[] result = new int[k];
        for(int i=0;i<k;i++){
            result[i] = sorted[i].Key;
        }
        return result;
    }
}
