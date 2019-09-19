using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    interface IStack
    {
        void Push(char c);
        char Pop();
        char Peek();
        int Size();
        bool IsEmpty();
    }
}
