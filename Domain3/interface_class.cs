public interface IExampleInterface
{
    void SomeMethod();
    int SomeProperty { get; set; }
}
public class ExampleClass : IExampleInterface
{   private int age;
    public void SomeMethod()
    {
        // Implementation of the SomeMethod from the interface
    }

    public int SomeProperty
    {
        get { return 0;/* Get implementation */ }
        set { this.age =50;/* Set implementation */ }
    }
}
