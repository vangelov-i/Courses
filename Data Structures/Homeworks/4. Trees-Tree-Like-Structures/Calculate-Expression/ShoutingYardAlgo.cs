using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ShoutingYardAlgo
{
    static void Main()
    {
        var pattern = new Regex(@"(-?\d+(,\d+)*(\.\d+(e\d+)?)?|[\(\)\+\-\*\/\^])");
        string arithmeticExpression = Console.ReadLine();
        var currentMatch = pattern.Match(arithmeticExpression);

        var postfixOutput = new Queue<string>();
        var operatorTokens = new Stack<string>();
        var operatorsWeight = new Dictionary<string, int>
                                  {
                                      { "(", 3 },
                                      { ")", 3 },
                                      { "^", 2 },
                                      { "*", 1 },
                                      { "/", 1 },
                                      { "-", 0 },
                                      { "+", 0 }
                                  };

        while (currentMatch.Value != string.Empty)
        {
            string token = currentMatch.Value;
            currentMatch = currentMatch.NextMatch();

            if (IsNumber(token))
            {
                postfixOutput.Enqueue(token);
            }
            else
            {
                if (operatorTokens.Count == 0)
                {
                    operatorTokens.Push(token);
                    continue;
                }

                string lastOperator = operatorTokens.Peek();
                bool lastPushedTokenHasPriority =
                    operatorsWeight[lastOperator] >= operatorsWeight[token];
                if (lastPushedTokenHasPriority && lastOperator != "(")
                {
                    postfixOutput.Enqueue(operatorTokens.Pop());
                }

                if (token != ")")
                {
                    operatorTokens.Push(token);
                }
                else if (lastOperator != "(")
                {
                    postfixOutput.Enqueue(operatorTokens.Pop());
                    operatorTokens.Pop();
                }
                else
                {
                    operatorTokens.Pop();
                }
            }
        }

        while (operatorTokens.Count > 0)
        {
            postfixOutput.Enqueue(operatorTokens.Pop());
        }

        var result = new Stack<double>();
        while (postfixOutput.Count > 0)
        {
            string currentToken = postfixOutput.Dequeue();
            double currentNum;
            if (double.TryParse(currentToken, out currentNum))
            {
                result.Push(currentNum);
                continue;
            }

            try
            {
                double rightOperand = result.Pop();
                double leftOperand = result.Pop();
                double expressionResult = CalculateExpression(leftOperand, currentToken, rightOperand);
                result.Push(expressionResult);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error");
                return;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error");
                return;
            }
        }

        Console.WriteLine("{0} = {1}", arithmeticExpression, result.Pop());
    }

    private static double CalculateExpression(double leftOperand, string operatorToken, double rightOperand)
    {
        if (operatorToken == "+")
        {
            return leftOperand + rightOperand;
        }

        if (operatorToken == "-")
        {
            double result = leftOperand - rightOperand;
            return leftOperand - rightOperand;
        }

        if (operatorToken == "*")
        {
            return leftOperand * rightOperand;
        }

        if (operatorToken == "/")
        {
            return leftOperand / rightOperand;
        }

        if (operatorToken == "^")
        {
            return Math.Pow(leftOperand, rightOperand);
        }

        throw new ArgumentException("Invalid operator.");
    }

    static bool IsNumber(string candidate)
    {
        double number;

        if (double.TryParse(candidate, out number))
        {
            return true;
        }

        return false;
    }
}