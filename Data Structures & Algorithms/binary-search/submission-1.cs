public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0;
        int right = nums.Length;
        while(left<right){
            int mid = (left+right)/2;
            if(nums[mid]<target) left=mid+1;
            else if(nums[mid]>target) right = mid;
            else if(nums[mid]==target) return mid;
        }
        return -1;
    }
}
