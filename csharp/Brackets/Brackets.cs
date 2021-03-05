using System.Collections.Generic;

public static class Brackets
{
    public static int Solution(string S) {
       
        if(S.Length <= 0)
            return 0;

        var ownArray = S.ToCharArray();
        var stack = new Stack<char>();

        for(var i = 0; i<ownArray.Length; i++){
            if(ownArray[i] == '(' || ownArray[i] == '[' || ownArray[i] == '{')
            {
                stack.Push(ownArray[i]);
            }
            else
            {
                if(stack.Count > 0 && stack.Peek() == GetLeft(ownArray[i]))
                {
                    stack.Pop();
                }
                else{
                    return 0;
                }
            }
        }

        return stack.Count == 0 ? 1 : 0;       
    }

    public static char GetLeft(char value){
        switch(value){
            case ')':
                return '(';
            case '}':
                return '{';
            case ']':
                return '[';
            default:
                return '0';
        }
    }
}