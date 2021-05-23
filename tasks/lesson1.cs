using System;

//Author: Prikhodov Alexander.

namespace tasks {
    public class dot{
        public double x, y;
        public void enter(){
            Console.WriteLine("Enter a dot in format \"x y\"\r\n");
            string[] res = Console.ReadLine().Split(' ');
            if (res.Length != 2) {
                Console.WriteLine("Incorrect input. Default value is assigned");
                return;
            }
            x = double.Parse(res[0]);
            y = double.Parse(res[1]);
        }
        public void subtract(dot d){
            x -= d.x;
            y -= d.y;
        }
        public double eucledeanNorm(){
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }

    public class lesson1{
        public static void enquete(){
            Console.WriteLine(">> enquette function:\r\n");
            string name = UM.enter("Please, enter your name");
            string surname = UM.enter("Please, enter your surname");
            int age = Int32.Parse(UM.enter("Enter your age"));
            Console.WriteLine("Name: " + name + ", surname: " + surname + ", age: " + age);
            Console.WriteLine(String.Format("Name: {0}, surname: {1}, age: {2}", name, surname, age));
            Console.WriteLine($"Name: {name}, surname: {surname}, age: {age}\r\n");
        }

        public static float bmi(){
            Console.WriteLine(">> bmi function:\r\n");
            float m = float.Parse(UM.enter("Enter your mass in kg"));
            float h = float.Parse(UM.enter("Enter your height in cm")) / 100f;
            float ind = m / (h * h);
            return ind;
        }
        
        public static double euclideanDist(){
            Console.WriteLine(">> euclideanDist function:\r\n");
            Console.WriteLine("Enter dots:");
            //string[] a = Console.ReadLine().Split(' ');
            dot d1 = new dot(), d2 = new dot();
            d1.enter();
            d2.enter();
            d1.subtract(d2);
            return d1.eucledeanNorm();
        }

        public static void swapVariables(int a, int b){
            Console.WriteLine(">> swapVariables function:\r\n");
            int c = a;
            Console.WriteLine($"SwapVariables:\r\nBefore swap: a = {a}, b = {b}");
            a = b;
            b = c;
            Console.WriteLine($"After swap: a = {a}, b = {b}\r\n");
        }

        public static void swapVariables2(int a, int b){
            Console.WriteLine(">> swapVariables2 function (without 3rd variable):\r\n");
            Console.WriteLine($"SwapVariables2:\r\nBefore swap: a = {a}, b = {b}");
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine($"After swap: a = {a}, b = {b}\r\n");
        }

        public static void info(string name, string surname, string city){
            Console.WriteLine(">> info function:\r\n");
            string line = $"Name: {name}, surname: {surname}, city: {city}";
            var pos = Console.GetCursorPosition();
            var size = Console.WindowWidth;
            Console.WriteLine(line);
            Console.SetCursorPosition((int)((size - line.Length) / 2), pos.Top);
            Console.WriteLine(line);
            Console.SetCursorPosition((int)((size - line.Length) / 2), pos.Top);
            UM.print(("name", name), ("surname", surname), ("city", city));
        }

        public static int task1(){
            enquete();
            return 0;
        }

        public static int task2(){
            Console.WriteLine("Your bmi: " + bmi());
            return 0;
        }

        public static int task3(){
            Console.WriteLine("Distance = " + euclideanDist());
            return 0;
        }

        public static int task4(){
            swapVariables(4753, 75);
            swapVariables2(45, 263);
            return 0;
        }

        public static int task5(){
            info("Alex", "Prikhodov", "Moscow");
            return 0;
        }
    }
}