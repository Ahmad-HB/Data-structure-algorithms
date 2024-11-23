namespace Stack;

public interface IStack
{
    bool isEmpty();
    bool push(int x);
    int pop();
    int peek();
    void print();
    int search(int value); 
}