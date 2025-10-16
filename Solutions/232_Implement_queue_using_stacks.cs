//https://leetcode.com/problems/implement-queue-using-stacks/
using System.ComponentModel.DataAnnotations;

namespace Algorithms.Solutions
{
    public class MyQueue
    {
        private List<int> _queue;
        public MyQueue() {
            _queue = new();
        }
        
        public void Push(int x)
        {
            _queue.Add(x);
        }

        public int Pop()
        {
            var firstItem = _queue[0];
            _queue.RemoveAt(0);
            return firstItem;
        }

        public int Peek()
        {
            var firstItem = _queue[0];
            return firstItem;
        }

        public bool Empty()
        {
            return _queue.Count() == 0;
        }
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */