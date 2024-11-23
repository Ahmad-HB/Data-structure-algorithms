namespace Stack;

public class Stack : IStack
{ 
    const int MAX = 1000;
    int top;
    int[] a = new int[MAX];

    public bool isEmpty() {
        return (top < 0);
    }

    public Stack() {
        top = -1;
    }

    public bool push(int x) {
        if (top >= (MAX - 1)) {
            Console.WriteLine("Stack Overflow");
            return false;
        } else {
            a[++top] = x;
            Console.WriteLine(x + " pushed into stack");
            return true;
        }
    }

    public int pop() {
        if (top < 0) {
            Console.WriteLine("Stack Underflow");
            return 0;
        } else {
            int x = a[top--];
            return x;
        }
    }

    public int peek() {
        if (top < 0) {
            Console.WriteLine("Stack Underflow");
            return 0;
        } else {
            int x = a[top];
            return x;
        }
    }

    public void print() {
        for (int i = top; i > -1; i--) {
            Console.Write(" " + a[i]);
        }
        Console.WriteLine();
    }
    
    public int search(int value) {
        for (int i = top; i >= 0; i--) {
            if (a[i] == value) {
                return top - i + 1;
            }
        }
        return -1;
    }
}