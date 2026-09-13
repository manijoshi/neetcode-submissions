public class Solution {
    public bool IsValid(string s) {
        LinkedList<char> stack = new LinkedList<char>();
        for(int i=0;i<s.Length;i++){
            if(s[i]=='[' || s[i]=='(' || s[i]=='{'){
                stack.AddLast(s[i]);
            }
            else{
                if(stack.Count==0){
                    return false;
                }
                if(s[i]==')' && stack.Last.Value=='('){
                    stack.RemoveLast();
                }
                else if(s[i]=='}' && stack.Last.Value=='{'){
                    stack.RemoveLast();
                }
                else if(s[i]==']' && stack.Last.Value=='['){
                    stack.RemoveLast();
                }
                else{
                    return false;
                }

            }
        }
        return stack.Count == 0;
    }
}
