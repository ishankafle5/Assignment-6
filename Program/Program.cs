
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question no 1
            Car car = new Car("Toyota", "2022", 200000);
            car.display();

            //Question 2
            BankAccount bank = new BankAccount("9865485642");
            bank.deposite(1000);
            bank.Withdraw(500);

            //Question 3
            Rectangle rectobj = new Rectangle(400f, 28f);
            Console.WriteLine(rectobj.CalculateArea());

            //Question 4
            Circle circle = new Circle();
            Console.WriteLine(circle.CalculateArea(5));

            //Question 5
            Student stud = new Student("John Doe", 20, "CSIT");
            stud.Introduce();

            //Question 6
            Stack<int> intStack = new Stack<int>();
            intStack.Push(5);
            intStack.Push(10);
            intStack.Push(15);

            intStack.Display();

            int poppedItem = intStack.Pop();
            Console.WriteLine($"Popped item: {poppedItem}");
            intStack.Display();

            Console.WriteLine(intStack.IsEmpty());
            Console.WriteLine(intStack.Peek());


            //Question 7
            Calender calender = new Calender();
            calender.PrintWeekdays();

            //Question 8
            Point2D pointA = new Point2D(1.0f, 2.0f);
            Point2D pointB = new Point2D(4.0f, 6.0f);

            float distance = Distance.CalculateDistance(pointA, pointB);

            Console.WriteLine($"Distance between Point A and Point B: {distance}");



        }
    }
}