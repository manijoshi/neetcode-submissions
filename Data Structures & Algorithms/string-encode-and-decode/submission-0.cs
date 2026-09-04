public class Solution {

    public string Encode(IList<string> strs) {
        string encoded_str = "";
        foreach(var str in strs){
            int len = str.Length;
            encoded_str+=len.ToString()+"#"+str;
        }
        return encoded_str;
    }

    public List<string> Decode(string s) {
        int i=0;
        List<string> result = new();
        while (i<s.Length){
            int j = i;
            while(s[j]!='#'){
                j++;
            }
            int len = int.Parse(s.Substring(i,j-i));
            j++;
            string decoded_string = s.Substring(j,len);
            
            result.Add(decoded_string);
            i=j+len;
        }

    
        return result;
   }
}
