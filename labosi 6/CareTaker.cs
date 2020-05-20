using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labosi_6
{
    //Zadatak 3
    class CareTaker
    {

        public Memento PreviousState { get; set; }
        Stack<Memento> stack = new Stack<Memento>();

        public void PushStack(Memento memento)
        {
            stack.Push(memento);
        }
        public Memento PopStack()
        {
            return stack.Pop();
        }


    }
}
