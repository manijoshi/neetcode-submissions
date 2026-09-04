public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length!=t.Length) return false;

        int[] frequency_s= new int[26];
        for(int i=0;i<s.Length;i++){
            if(frequency_s[s[i]-'a']!=0){
                frequency_s[s[i]-'a']++;
            }
            else{
                frequency_s[s[i]-'a']=1;
            }
        }
        int[] frequency_t= new int[26];
        for(int i=0;i<t.Length;i++){
            if(frequency_t[t[i]-'a']!=0){
                frequency_t[t[i]-'a']++;
            }
            else{
                frequency_t[t[i]-'a']=1;
            }
        }
        
        for(int i=0;i<26;i++){
            if(frequency_s[i]!=frequency_t[i]){
                return false;
            }
        }
        return true;
       
    }
}
