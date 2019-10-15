using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.CommercialDataLinkedList
{
    class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node()
        {
           
            this.next = null;
        }
        public T getData()
        {
            return data;
        }
        public Node<T> getLink()
        {
            return next;
        }
    }
}
