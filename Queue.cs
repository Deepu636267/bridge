// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Queue.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sachin Kumar Maurya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Queue is a class for all the Queue Operation 
    /// </summary>
    class Queue
    {
        char[] queue = new char[20];
        int front = -1;
        int rear = -1;
        int size = 0;
        /// <summary>
        /// Adds the element from  rear.
        /// </summary>
        /// <param name="item">The item.</param>
        public void addRear(char item)
        {
            ////chck the queue array is full
            if(isFull())
            {
                Console.WriteLine("Queue is Full");
                return;
            }
            else if(isEmpty())
            {
                
                rear = 0;
                queue[rear] = item;
                size++;
            }
            else
            {
                queue[++rear] = item;
                size++;
            }
        }
        /// <summary>
        /// Adds the element from  front.
        /// </summary>
        /// <param name="item">The item.</param>
        public void addFront(char item)
        {
            if (front==20)
            {
                Console.WriteLine("Queue is Full");
                return;
            }
            else if (isEmpty())
            {
                front = rear = 0;
                queue[front] = item;
                size++;
            }
            else
            {
                queue[++front] = item;
                size++;
            }
        }
        /// <summary>
        /// Removes the element from  rear.
        /// </summary>
        /// <returns></returns>
        public char removeRear()
        {
            char it = queue[rear];
          //   Console.WriteLine(item);
            rear--;
            size--;
            return it;
            
         }
        /// <summary>
        /// Removes the element from front.
        /// </summary>
        /// <returns></returns>
        public char removeFront()
        {

            front++;
            char item = queue[front];
           // Console.WriteLine(item);
               
                size--;
                return item;
        }
        /// <summary>
        /// Peeks this instance for finding the top element in queue.
        /// </summary>
        public void peek()
        {
            if(isEmpty())
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("Front Element is : " + queue[front]);
            }
        }
        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void display()
        {
            if(isEmpty())
            {
                return;
            }
            else
            {
                for(int i=0;i<rear+1;i++)
                Console.WriteLine(queue[i]);
            }
        }
        /// <summary>
        /// Determines whether this instance is full.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is full; otherwise, <c>false</c>.
        /// </returns>
        public bool isFull()
        {
            if(rear==20)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool isEmpty()
        {
            if(front==-1 && rear==-1)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Totals this instance gives the total size of Queue.
        /// </summary>
        /// <returns></returns>
        public int total()
        {
            return size;
        }
    }
}