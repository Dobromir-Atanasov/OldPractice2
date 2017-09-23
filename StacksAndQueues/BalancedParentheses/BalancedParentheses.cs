using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            char[] tokens = Console.ReadLine().ToCharArray(); //new char[] { '{', '}', '[', '(', ')', ']' };
            Stack<char> st = new Stack<char>();
            bool flag = true;
            if (tokens.Length < 1 || tokens.Length % 2 != 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                foreach (var token in tokens)
                {
                    switch (token)
                    {
                        case '{':
                            st.Push(token);
                            break;
                        case '}':
                            if (st.Pop() != '{')
                            {
                                flag = false;
                            }
                            break;
                        case '(':
                            st.Push(token);
                            break;
                        case ')':
                            if (st.Pop() != '(')
                            {
                                flag = false;
                            }
                            break;
                        case '[':
                            st.Push(token);
                            break;
                        case ']':
                            if (st.Pop() != '[')
                            {
                                flag = false;
                            }
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine(flag ? "YES" : "NO");
            }
        }
    }
}

// Folowing solution thas not work on strings like
// {}({[]})
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BalancedParentheses
//{
//    class BalancedParentheses
//    {
//        static void Main(string[] args)
//        {
//            char[] token = Console.ReadLine().ToCharArray();
//            if (token.Length < 1 || token.Length % 2 != 0)
//            {
//                Console.WriteLine("NO");
//            }
//            else
//            {
//                bool isProblemFound = false;
//                Queue<char> q = new Queue<char>(token);
//                Stack<char> s = new Stack<char>(token);
//                char sCharChanged = new char();
//                for (int i = 0; i < token.Length / 2; i++)
//                {
//                    //sCharChanged = s.Pop();
//                    switch (s.Pop())
//                    {
//                        case '}':
//                            sCharChanged = '{';
//                            break;
//                        case ']':
//                            sCharChanged = '[';
//                            break;
//                        default:
//                            sCharChanged = '(';
//                            break;
//                    }
//                    if (q.Dequeue() != sCharChanged)
//                    {
//                        Console.WriteLine("NO");
//                        isProblemFound = true;
//                        break;
//                    }
//                }
//                if (!isProblemFound)
//                {
//                    Console.WriteLine("YES");
//                }
//            }
//        }
//    }
//}
