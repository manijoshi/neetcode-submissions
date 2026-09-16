public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach(string token in tokens){
            
            if(token == "+" || token=="-" || token=="/" || token=="*"){
                int n1 = stack.Pop();
                int n2 = stack.Pop();
                if(token == "+"){
                    int cal = n1+n2;
                    stack.Push(cal);
                }
                else if (token=="-"){
                    int cal = n2-n1;
                    stack.Push(cal);
                }
                else if (token=="*"){
                    int cal = n1*n2;
                    stack.Push(cal);
                }
                else if(token=="/"){
                    int cal = n2/n1;
                    stack.Push(cal);
                }
            }
            else{
                stack.Push(int.Parse(token));
            }
        }
        return stack.Peek();
    }
}