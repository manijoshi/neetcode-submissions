public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        
        int left = 0;
        int n = nums.Length;
        int[] result = new int[n-k+1];
        int resultIdx = 0;
        LinkedList<int> deque = new LinkedList<int>();//double ended queue
        for(int right=0;right<nums.Length;right++){
            //1. remove smaller from the back;
            while(deque.Count>0 && nums[deque.Last.Value]<=nums[right]){
                deque.RemoveLast();
            }
            //2. Add in the queue
            deque.AddLast(right);

            //3. Remove expired idx from the start. winodw size exceeded
            if(deque.First.Value<left){
                deque.RemoveFirst();
            }
            //4. if window size is k record maximum
            if(right-left+1 == k){
                result[resultIdx] = nums[deque.First.Value];
                resultIdx++;
                left++;
            }
        }
        return result;
    }
}
