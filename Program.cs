namespace practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
           //task 1
            string name = "Eshraq";
            int age = 22;
            double height = 1.63;
            bool isStudent = true;
 // Printing the info card
         Console.WriteLine("----- Personal Info Card -----");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Student: " + isStudent);



    //////////////////////////////////////////////////////////////////
            //task2

            Console.Write("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());
            double area = length * width;
            double perimeter = 2 * (length + width);
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
        }
    }
}
