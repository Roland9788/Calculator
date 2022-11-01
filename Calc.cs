using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{

    class _prior
    {
        public int prior(string x)
        {
            if ((x == "*") || (x == "/")) return 2;
            if ((x == "+") || (x == "-")) return 1;
            if ((x == "(") || (x == ")")) return 0;
            return -1;
        }
    }

    internal class Calc
    {
        stack _stack = new stack();
        List<string> note = new List<string>();
        string[] pnote = new string[0];
        Mystack vect = new Mystack();
        string temp;
        int i = 0, j = 0, p = 0, size = 0;


        public Calc()
        {
            _stack = new stack();
            note = new List<string>();
            pnote = new string[size];
            vect = new Mystack();
            temp = "";
            i = 0; j = 0; p = 0;
        }

        public void addnote(string x)
        {
            note.Add(x);
            size++;
        }

        public void raschet()
        {
            pnote = new string[size];
            for (i = 0; i < note.Count; i++)
            {
                if (note[i] == "(") { _stack.push(note[i].ToString()); }
                else if ((note[i] == "+") || (note[i] == "-") || (note[i] == "/") || (note[i] == "*"))
                {
                    while ((!_stack.empty()) && (_stack.top_prior() >= _stack.p.prior(note[i].ToString())))
                    {
                        pnote[p] = _stack.pop();
                        p++;
                    }
                    _stack.push(note[i].ToString());
                }
                else if (note[i] == ")")
                {
                    while ((!_stack.empty()) && (_stack.get_top_element() != ")"))
                    {
                        pnote[p] = _stack.pop();
                        p++;
                        if ((temp = _stack.pop()) == "(")
                        {
                            break;
                        }
                    }
                }
                else
                {
                    if (note[i]!="")
                    {
                        pnote[p] = note[i].ToString();
                        p++;
                    }
                }
            }
            while (!_stack.empty())
            {
                pnote[p] = _stack.pop();
                p++;
            }


            string[] expression = new string[size];
            int number = 0;
            bool flag = true;
            int f = 0;
            float otvet = 0;
            init(ref vect);
            expression = pnote;
            int n;


            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i]==null)
                {
                    break;
                }
                if (int.TryParse(expression[i],out n))
                {
                    number *= 10;
                    number += Convert.ToInt32(expression[i]);
                    flag = true;
                }
                else
                {
                    if (expression[i] != " ")
                    {
                        float num2 = stkTop(ref vect);
                        pop(ref vect);
                        float num1 = stkTop(ref vect);
                        pop(ref vect);

                        if (expression[i] == "+")
                        {
                            otvet = num1 + num2;
                            push(ref vect, otvet);
                            otvet = stkTop(ref vect);
                        }

                        if (expression[i] == "-")
                        {
                            otvet = num1 - num2;
                            push(ref vect, otvet);
                            otvet = stkTop(ref vect);
                        }

                        if (expression[i] == "*")
                        {
                            otvet = num1 * num2;
                            push(ref vect, otvet);
                            otvet = stkTop(ref vect);
                        }

                        if (expression[i] == "/")
                        {
                            otvet = num1 / num2;
                            push(ref vect, otvet);
                            otvet = stkTop(ref vect);
                        }
                        flag = false;
                    }
                }
                if (flag == true)
                {
                    push(ref vect, number);
                    number = 0;
                }
            }
        }

        public float GetRezult()
        {
            return stkTop(ref vect);
        }


        void init(ref Mystack stk)
        {
            stk.top = 0;
        }

        void push(ref Mystack stk, float f)
        {
            if (stk.top < 100)
            {
                stk.elem[stk.top] = f;
                stk.top++;
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        float pop(ref Mystack stk)
        {
            float elem;
            if ((stk.top) > 0)
            {
                stk.top--;
                elem = stk.elem[stk.top];
                return elem;
            }
            else
            {
                MessageBox.Show("ERROR!");
                return 0;
            }
        }

        float stkTop(ref Mystack stk)
        {
            if ((stk.top) > 0)
            {
                return stk.elem[stk.top - 1];
            }
            else
            {
                MessageBox.Show("ERROR!");
                return 0;
            }
        }

        int getcount(ref Mystack stk)
        {
            return stk.top;
        }

        int isempty(ref Mystack stk)
        {
            if (stk.top == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


    }

    class stack
    {
        public _prior p = new _prior();
        public int top;
        public string[] body = new string[100];
        public stack()
        {
            top = 0;
        }

        public bool empty()
        {
            if (top == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string get_top_element()
        {
            return body[top];
        }

        public int top_prior()
        {
            return p.prior(body[top]);
        }
        public void push(string x)
        {
            body[top] = x;
            top++;
        }
        public string pop()
        {
            top--;
            return body[top];
        }
    }


    struct Mystack
    {
        public float[] elem = new float[100];
        public int top = 0;
        public Mystack() { }
    }


}
