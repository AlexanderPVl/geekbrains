using System;

//Author: Prikhodov Alexander.

namespace tasks {

    public class usefulMethods{
        public static string enter(string message){
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static void print(params System.ValueTuple<string, object>[] args){
            var pos = Console.GetCursorPosition();
            var size = Console.WindowWidth;
            string line;
            Console.WriteLine("");
            foreach(var e in args){
                line = e.Item1 + ": " + e.Item2;
                Console.SetCursorPosition((int)((size - line.Length) / 2), pos.Top);
                Console.Write(line + "\r\n");
            }
        }
    }

    public class lesson1{
        public static void enquete(){
            string name = usefulMethods.enter("Please, enter your name");
            string surname = usefulMethods.enter("Please, enter your surname");
            int age = Int32.Parse(usefulMethods.enter("Enter your age"));
            Console.WriteLine("Name: " + name + ", surname: " + surname + ", age: " + age);
            Console.WriteLine(String.Format("Name: {0}, surname: {1}, age: {2}", name, surname, age));
            Console.WriteLine($"Name: {name}, surname: {surname}, age: {age}\r\n");
        }

        public static float bmi(){
            float m = float.Parse(usefulMethods.enter("Enter your mass in kg"));
            float h = float.Parse(usefulMethods.enter("Enter your height in cm")) / 100f;
            float ind = m / (h * h);
            return ind;
        }
        
        public static double euclideanDist(double x1, double y1, double x2, double y2){
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        public static void swapVariables(int a, int b){
            int c = a;
            Console.WriteLine($"SwapVariables:\r\nBefore swap: a = {a}, b = {b}");
            a = b;
            b = c;
            Console.WriteLine($"After swap: a = {a}, b = {b}\r\n");
        }

        public static void swapVariables2(int a, int b){
            Console.WriteLine($"SwapVariables2:\r\nBefore swap: a = {a}, b = {b}");
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine($"After swap: a = {a}, b = {b}\r\n");
        }

        public static void task5(string name, string surname, string city){
            string line = $"Name: {name}, surname: {surname}, city: {city}";
            var pos = Console.GetCursorPosition();
            var size = Console.WindowWidth;
            Console.WriteLine(line);
            Console.SetCursorPosition((int)((size - line.Length) / 2), pos.Top);
            Console.WriteLine(line);
            Console.SetCursorPosition((int)((size - line.Length) / 2), pos.Top);
            usefulMethods.print(("name", name), ("surname", surname), ("city", city));
        }
    }
}