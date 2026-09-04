public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length-1;
        int result = 0;
        while(left<right){
            int area = Math.Abs(left-right)*Math.Min(heights[left],heights[right]);
            if(heights[left]<heights[right]){
                left++;
            }
            else{
                right--;
            }
            result = Math.Max(result,area);
        }
        return result;
    }
}
