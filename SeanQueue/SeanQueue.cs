using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeanQueue
{
    class SeanQueue<T>
    {
        public SeanNode<T> head;
        public SeanNode<T> tail;
        public int Size { get; set; }

        public SeanQueue() { }
        public SeanQueue(T newName)
        {
            SeanNode<T> newHead = new SeanNode<T>(newName);
            head = newHead;
            tail = newHead;
            Size++;
        }

        public void Push(T newName)
        {
            if(head == null)
            {
                SeanNode<T> newHead = new SeanNode<T>(newName);
                head = newHead;
                tail = newHead;
                Size++;
            }
            else
            {
                SeanNode<T> newTail = new SeanNode<T>(newName);
                SeanNode<T> oldTail = tail;
                tail.Child = newTail;
                tail = tail.Child;
                tail.Parent = oldTail;
                Size++;
            }


        }

        public void Pop()
        {
            if (head != null)
            {
                if (head.Child == null)
                {
                    head = null;
                    tail = null;
                    Size--;
                }
                else
                {
                    head = head.Child;
                    head.Parent = null;
                    Size--;
                }
            }
        }

        public T Poll()
        {
            T returnVal = default(T);

            if (head != null)
            {
                returnVal = head.Name;

                if (head.Child == null)
                {
                    head = null;
                    tail = null;
                    Size--;
                }
                else
                {
                    head = head.Child;
                    head.Parent = null;
                    Size--;
                }
            }

            return returnVal;
        }

    }
}
