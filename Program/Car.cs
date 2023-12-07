
namespace Program
{
    class Car
    {
        private string brand;
        private string year;
        private int price;

        public Car(string brand, string year, int price)
        {
            this.brand = brand;
            this.year = year;
            this.price = price;
        }
        public void getdata()
        {
            Console.WriteLine(this.brand);
            Console.WriteLine(this.year);
            Console.WriteLine(this.price);

        }

        public void display()
        {
            Console.WriteLine(this.brand);
            Console.WriteLine(this.year);
            Console.WriteLine(this.price);
        }



    }
}
