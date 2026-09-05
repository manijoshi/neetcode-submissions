public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length>s2.Length){
            return false;
        }

        int[] count1 = new int[26];
        int[] count2 = new int[26];
        
        int n = s1.Length;

        for(int i=0;i<n;i++){
            count1[s1[i]-'a']++;
        }
        int left = 0;

        for(int right = 0 ;right<s2.Length;right++){
            count2[s2[right]-'a']++;

            int windowSize = right-left+1;
            
            if(windowSize>n){
                count2[s2[left]-'a']--;
                left++;
            }
            windowSize = right-left +1;
            if(windowSize==n){
                if(count1.SequenceEqual(count2)){
                    return true;
                }
            }
        }
        return false;
    }
}
