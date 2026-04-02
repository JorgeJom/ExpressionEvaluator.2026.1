namespace ExpressionEvaluator.Core;

public class Evaluator
{
    public static double Evaluate(string infix)
    {
        var postfix = InfixToPostfix(infix);
        return EvaluatePostfix(postfix);
    }

    private static string InfixToPostfix(string infix)
    {
        var postFix = string.Empty;
        var stack = new Stack<char>();

        int i = 0;
        while (i < infix.Length) // Change
        {
            char item = infix[i];

            // If what I'm reading is a digit or a period, keep reading until the entire number is finished.
            if (char.IsDigit(item) || item == '.') 
            {
                string number = "";
                while (i < infix.Length && (char.IsDigit(infix[i]) || infix[i] == '.'))
                {
                    number += infix[i];
                    i++;
                }
                postFix += number + " "; // here
                continue;
            }
            if (IsOperator(item))
            {
                if (stack.Count == 0)
                {
                    stack.Push(item);
                }
                else
                {
                    if (item == ')')
                    {
                        do
                        {
                            postFix += stack.Pop() + " "; // here
                        } while (stack.Peek() != '(');
                        stack.Pop();
                    }
                    else
                    {
                        if (PriorityInfix(item) > PriorityStack(stack.Peek()))
                        {
                            stack.Push(item);
                        }
                        else
                        {
                            postFix += stack.Pop() + " "; // here
                            stack.Push(item);
                        }
                    }
                }
            }
            i++;
        }
        while (stack.Count > 0)
        {
            postFix += stack.Pop() + " "; // here
        }
        return postFix;
    }

    private static int PriorityStack(char item) => item switch
    {
        '^' => 3,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 0,
        _ => throw new Exception("Sintax error."),
    };

    private static int PriorityInfix(char item) => item switch
    {
        '^' => 4,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 5,
        _ => throw new Exception("Sintax error."),
    };

    private static double EvaluatePostfix(string postfix)
    {
        var stack = new Stack<double>();
        foreach (string token in postfix.Split(' ', StringSplitOptions.RemoveEmptyEntries)) // Change
        {
            if (token.Length == 1 && IsOperator(token[0]))
            {
                var b = stack.Pop();
                var a = stack.Pop();
                stack.Push(token[0] switch
                {
                    '+' => a + b,
                    '-' => a - b,
                    '*' => a * b,
                    '/' => a / b,
                    '^' => Math.Pow(a, b),
                    _ => throw new Exception("Sintax error."),
                });
            }
            else
            {
                stack.Push(double.Parse(token, System.Globalization.CultureInfo.InvariantCulture)); // Change
            }
        }
        return stack.Pop();
    }

    private static bool IsOperator(char item) => "+-*/^()".Contains(item);
}