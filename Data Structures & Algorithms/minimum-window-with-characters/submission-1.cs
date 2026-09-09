public class Solution {
    public string MinWindow(string s, string t) {
        int[] need = new int[128];
        int[] window = new int[128];
        
        for(int i=0;i<t.Length;i++){
            need[t[i]]++;
        }
        
        int windowLength = 0;
        int left = 0;
        int start = 0;
        int minLength = int.MaxValue;
        for(int right=0;right<s.Length;right++){
            window[s[right]]++;
            
            while(Contains(need,window)){
                int currentLength = right-left+1;

                if(currentLength<minLength){
                    minLength = currentLength;
                    start = left;
                }
                window[s[left]]--;
                left++;
            }
        }
        return minLength == int.MaxValue ? "" : s.Substring(start,minLength);
    }

    private bool Contains(int[] need, int[] window){
        for(int i=0;i<128;i++){
            if(window[i]<need[i]){
                return false;
            }
        }
        return true;
    }
}
