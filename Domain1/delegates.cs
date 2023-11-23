using System;

namespace DelegateExample;
public delegate void MyDelegate(string name);
class MyEvent
{
    public void DisplayMessage(string name)
    {
        Console.WriteLine($"Hello : {name}");
    }
}
