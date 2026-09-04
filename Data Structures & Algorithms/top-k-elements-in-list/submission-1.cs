public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> freq = new();
        for(int i=0;i<nums.Length;i++){
            freq[nums[i]] = freq.GetValueOrDefault(nums[i])+1;
        }
        // bucket sort
        List<int>[] buckets = new List<int>[nums.Length+1];
        foreach(var pair in freq){
            int key = pair.Key;
            int frequency = pair.Value;
            if(buckets[frequency]==null){
                buckets[frequency] = new List<int>();
            }
            buckets[frequency].Add(key);
        }
        int index = 0;
        int[] result = new int[k];
        for(int i=buckets.Length-1;i>=0;i--){
            if(buckets[i]==null)
                continue;
            foreach(var num in buckets[i]){
                result[index++] = num;
            }
            if(index==k)
                break;
        }
        return result;

    }
}
