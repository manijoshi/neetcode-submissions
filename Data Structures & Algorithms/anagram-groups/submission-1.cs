public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> groups = new();
        for(int i=0;i<strs.Length;i++){
            string s = strs[i];        
            int[] freq = new int[26];
            for(int j=0;j<s.Length;j++){
                freq[s[j]-'a']++;
            }
            string final_key = string.Join("#",freq);
            if(!groups.TryGetValue(final_key,out List<string>? group)){
                group = new List<string>();
                groups[final_key] = group;
            }
            group.Add(s);
        }
        return groups.Values.ToList();
    }
}
