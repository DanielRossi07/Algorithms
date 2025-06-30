//https://leetcode.com/problems/min-stack/

public class MinStack
{
    private int[] _stack;
    private int _capacity;
    private int _count;
    private int _minValue;
    public MinStack()
    {
        _capacity = 5;
        _stack = new int[_capacity];
        _count = 0;
    }

    public void Push(int val)
    {
        _stack[_count] = val;
        if (_count == 0 || val < _minValue)
        {
            _minValue = val;
        }
        _count ++;
        if (_capacity / _count < 2)
        {
            Resize();
        }   
    }

    public void Pop()
    {
        var valueToRemove = _stack[_count - 1];
        _stack[_count - 1] = 0;
        _count --;
        if (valueToRemove == _minValue) {
            SetMin();
        }
    }

    public int Top()
    {
        return _stack[_count - 1];
    }

    public int GetMin()
    {
        return _minValue;
    }

    private void Resize()
    {
        var newCapacity = _capacity * 2;
        var newStack = new int[newCapacity];
        Array.Copy(_stack, newStack, _capacity);
        _capacity = newCapacity;
        _stack = newStack;
    }

    private void SetMin()
    {
        if (_count - 1 < 0)
        {
            _minValue = 0;
            return;
        }
        var min = _stack[_count - 1];
        for(var pos = 0; pos < _count; pos++)
        {
            if (_stack[pos] < min)
            {
                min = _stack[pos];
            }
        }
        _minValue = min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */

//["MinStack","push","push","push","push","getMin","pop","getMin","pop","getMin","pop","getMin"]
//[[],[2],[0],[3],[0],[],[],[],[],[],[],[]]
//[null,null,null,null,null,0,null,0,null,0,null,2]

//["MinStack","push","push","push","top","pop","getMin","pop","getMin","pop","push","top","getMin","push","top","getMin","pop","getMin"]
//[[],[2147483646],[2147483646],[2147483647],[],[],[],[],[],[],[2147483647],[],[],[-2147483648],[],[],[],[]]