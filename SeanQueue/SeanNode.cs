using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeanQueue
{
    class SeanNode<T>
    {
        public T Name { get; set; }
        public SeanNode<T> Parent;
        public SeanNode<T> Child;

        public SeanNode(){}
        public SeanNode(T newName)
        {
            Name = newName;
        }
    }
}
