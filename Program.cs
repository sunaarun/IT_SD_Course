// See https://aka.ms/new-console-template for more information
using System;
using DelegateExample;


class IT
{
    static void Main(string[] args)
    {
        /* for (;;)
        {
            // Code inside the loop
            Console.WriteLine("hello");
        }*/
       // int[] arr = { 1, 5, 4, 3, 0 };
       // SortClass sort = new SortClass();
     //   sort.mergeSorting(arr);
            Stack<int> myStack = new Stack<int>();
        Queue<int> queue1 = new Queue<int>();
        Queue<int> queue2 = new Queue<int>();

        myStack.Push(10);
        myStack.Push(20);
        myStack.Push(30);

        queue1.Enqueue(40);
        queue1.Enqueue(50);
        queue1.Enqueue(60);
        queue1.Enqueue(myStack.Pop());


        queue2.Enqueue(queue1.Dequeue());
        queue2.Enqueue(queue1.Dequeue());
        queue2.Enqueue(myStack.Pop());
        queue2.Enqueue(myStack.Pop());
        foreach(int q in queue2)
        {
            Console.WriteLine(q);

        }
    }

}


/*
You can use these here inside Main function, 
*/
// Console.WriteLine("Enter the number of Fibonacci numbers to print: ");
// int count = int.Parse(Console.ReadLine());
//  Fibonacci fibonacci =new Fibonacci();
// Console.WriteLine("Fibonacci Sequence:");
// fibonacci.PrintFibonacciSequence(count);
//LogicalError logical = new LogicalError();
//logical.logic(5,6);

/* ----------------------------------------------------------*/
//int [] arr = {1,5,4,3,0};
//MyEvent myEvent = new MyEvent();
//MyDelegate myDelegate= myEvent.DisplayMessage;
//myDelegate("Sanaa"); 
// SortClass sort =  new SortClass();
//sort.selection(arr);

/*--------------------------------------------------------------*/
//StaticExample.name="Sanaa";
//   // StaticExample.DisplayMessage();

//     Car c1=new Car("Red", 250, 2020, "2020- car");
//     c1.car_message(); // 
//     c1.stop();
//     //Console.WriteLine(c1.color + " "+ c1.model);
//     // Vehicle veh1 = new Vehicle();
//     // veh1.model=2019;
//     // veh1.name="Vehicle 2019";
//     // Console.WriteLine("Name: "+ veh1.name + "  Model: " +veh1.model +"\n");
//     // // Vehicle v2= new Vehicle();
//     // // v2.model=2001;
//     // // v2.name="Vehicle 2001";
//     // //  Console.Write("Name: "+ v2.name + " is " );
//     // // v2.move(); // calling move method      


/**
MVCPatternDemo mVCPattern = new MVCPatternDemo();
        //fetch student record based on his roll no from the database
        Student model = mVCPattern.retriveStudentFromDatabase();

        //Create a view : to write student details on console
        StudentView view = new StudentView();

        StudentController controller = new StudentController(model, view);

        controller.updateView();

        //update model data
        controller.setStudentName("John");

        controller.updateView();
        Console.WriteLine("Sanaa");
       */