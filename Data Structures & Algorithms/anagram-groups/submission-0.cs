public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> groups = new();
        for(int i=0;i<strs.Length;i++){
            string s = strs[i];        
            int[] freq = new int[26];
            for(int j=0;j<s.Length;j++){
                freq[s[j]-'a']++;
            }
            string final_key = "";
            for(int k=0;k<26;k++){
                final_key+=freq[k]+"#";
            }
            if(!groups.ContainsKey(final_key)){
                groups[final_key] = new List<string>();
            }
            groups[final_key].Add(s);
        }
        return groups.Values.ToList();
    }
}
