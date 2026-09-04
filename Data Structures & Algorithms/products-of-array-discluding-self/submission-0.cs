public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // prefix product
        int[] result = new int[nums.Length];
        int len = nums.Length;
        result[0] = 1;
        for(int i=1;i<len;i++){
            result[i] = result[i-1]*nums[i-1];
        }
        //[1,2,4,6] => [1,1,2,8]
        
        //sufix product
        int suffix = 1;
        for(int i=len-1;i>=0;i--){
            result[i] = result[i]*suffix;
            suffix = suffix * nums[i];
        }
        // [1,1,12,8]->[1,24,12,8]->[48,24,12,8]

        return result;
    }
}
