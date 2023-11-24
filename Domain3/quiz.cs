using System;

// Base class
public class A_Parent
{
    public virtual void DisplayMessage()
    {
        Console.WriteLine("from A");
    }
    public void Sum(int a,int b)
    {
       int c = a+b;
        Console.WriteLine("Inside  A, the sum is "+c );
    }
}

// Derived class 1
public class B_child : A_Parent
{
    public override void DisplayMessage()
    {
        Console.WriteLine("Inside B");
    }
}

// Derived class 2
public class C_child : A_Parent
{
    public override void DisplayMessage()
    {
        Console.WriteLine("Inside C");
    }
    public void AddNumbers(int a, int b)
    {
        base.Sum(a,b);
    }
}
public class D_child:C_child
{
    public void SumC(int a, int b)
    {
        base.AddNumbers(a,b);
    }
}
