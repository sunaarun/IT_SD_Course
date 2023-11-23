using System.Diagnostics;

class Vehicle{
    public int model; // attributes or property
     public string name; // attribute or property
   public Vehicle(int m, string nam)
   {
        this.model= m;
        this.name=nam;
   }
   public Vehicle()
   {
        this.model= 0;
        this.name="";
   }
    public void move()
    {
        Console.WriteLine("Moving ...");
    }
    public void DisplayMessage()
    {
      Console.WriteLine("Inside Parent Vehicle");
    }
    public virtual void stop()
    { // behavior 
      Console.WriteLine("Stop ...");
    }
     }
class Car :Vehicle
{
  public string color; int speed;
   public override void stop()
  {  if(speed >250)
     Console.WriteLine("stop .. ");
     else
     Console.WriteLine("Puase .. ");
  }
   public Car(string color, int speed, int m, string nam)
  {
    this.color= color;
    this.speed=speed;
    this.model= m; // inherited from Vehicle (Parent)
    this.name= nam; // inherited from Base class or Parent 
  }
  public void car_message()
  {
    Console.WriteLine("Calling Parent Display Message ...");
    base.DisplayMessage();
  }
 
}