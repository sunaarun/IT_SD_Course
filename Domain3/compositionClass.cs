public class A 
{
   public int a=10;
   public int b=5;
}

public class B 
{
    A aObj;
    string s;

    public void DisplayMessage()
    {
        int c = aObj.a + aObj.b;
        Console.WriteLine(c); // will print 15
    }
}