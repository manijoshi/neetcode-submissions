public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> stack = new Stack<int>();
        int n = temperatures.Length;
        int[] result = new int[n];
        for(int i=0;i<n;i++){
            while(stack.Count>0 && temperatures[i]>temperatures[stack.Peek()]){
                int day = stack.Pop();
                result[day] = i-day;
            }
            stack.Push(i);
        }
        return result;
    }
}
