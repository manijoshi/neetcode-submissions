public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int> stack = new Stack<int>();
        int maxarea=0;
        for(int i=0;i<=heights.Length;i++){
            int currentHeight = (i == heights.Length)
                ? 0
                : heights[i];
            while(stack.Count>0 && currentHeight<heights[stack.Peek()]){
                int index = stack.Pop();
                int height = heights[index];
                int width;
                if(stack.Count == 0){
                    width = i;
                }
                else{
                    width = i-stack.Peek()-1;
                }
                int area = width * height;
                maxarea = Math.Max(maxarea,area);
            }            
            stack.Push(i);
        }
        return maxarea;
    }
}
