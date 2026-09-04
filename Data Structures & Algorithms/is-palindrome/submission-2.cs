public class Solution {
    public bool IsPalindrome(string s) {

        int left = 0;
        int right = s.Length-1;
        while(left<right){
            while(left<right && !IsLetterOrDigit(s[left])){
                left++;
            }
            while(left<right && !IsLetterOrDigit(s[right])){
                right--;
            }

            if(char.ToLower(s[left])!=char.ToLower(s[right])){
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
    public bool IsLetterOrDigit(char c){
        if((c>='a' && c<='z') || (c>='A' && c<='Z') || (c>='0' && c<='9')){
            return true;
        }
        else return false;
    }
}
