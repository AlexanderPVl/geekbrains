using System;

//Author: Prikhodov Alexander.

namespace tasks {
    public class lesson2{

        public static double userMin(double a1, double a2, double a3){
            return Math.Min(Math.Min(a1, a2), a3);
        }
        public static double numberOfDigits(){
            int n = 0;
            try{
                n = int.Parse(Console.ReadLine());
            } catch {
                Console.WriteLine("Couldn't parse your input. Set to the default value (0)");
            }

            if (n == 0) return 1;
            int cnt = 0;
            while(n != 0){
                n /= 10;
                ++cnt;
            }
            return cnt;
        }

        public static int infiniteInput(){
            Console.WriteLine(">> Task 3\r\nEnter integer numbers in separate lines:");
            int a = 0;
            int sum = 0;
            do{
                try{
                    a = int.Parse(Console.ReadLine());
                    if (a > 0 && a % 2 == 1) sum += a;
                } catch{ Console.WriteLine("Couldn't process your input, set to the default value (0)"); a = -1; }
                
                
            } while(a != 0);
            return sum;
        }

        public static bool auth(authentication auth){
            string log, pass;
            Console.WriteLine("Enter login:");
            log = Console.ReadLine();
            Console.WriteLine("Enter password");
            pass = Console.ReadLine();
            return auth.login == log && auth.password == pass;
        }

        public static void recursionPrint(int a, int b){
            if (a <= b){
                Console.WriteLine(a);
                recursionPrint(a + 1, b);
            }
        }

        public static int recursionSum(int a, int b){
            if (a <= b){
                return a + recursionSum(a + 1, b);
            }
            return 0;
        }

        public static int task1(){
            Console.WriteLine(">>Task1\r\nEnter three numbers in one line:");
            try {
                string[] nums = Console.ReadLine().Split(' ');
                Console.WriteLine(userMin(double.Parse(nums[0]), double.Parse(nums[1]), double.Parse(nums[2])));
            }
            catch{
                Console.WriteLine("Couldn't execute tesk1");
            }
            return 0;
        }

        public static int task2(){
            Console.WriteLine(">> Task 2\r\nEnter an integer:");
            Console.WriteLine("Number of digits: " + numberOfDigits());
            return 0;
        }

        public static int task3(){
            Console.WriteLine(">> Task 3");
            Console.WriteLine("Sum: " + infiniteInput());
            return 0;
        }

        public static int task4(){
            Console.WriteLine(">> Task 4");
            Console.WriteLine("Authentication ");
            Console.Write(auth(new authentication("root", "GeekBrains")) ? "succeeded\r\n" : "failed\r\n");
            return 0;
        }

        public static int task5(){
            Console.WriteLine(">> Task 4 (coming soon)");
            return 0;
        }

        public static int task6(){
            Console.WriteLine(">> Task 4 (coming soon)");
            return 0;
        }

        public static int task7(){
            Console.WriteLine(">> Task 7");
            int a, b;
            try{
                Console.WriteLine("Enter a: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter b: ");
                b = int.Parse(Console.ReadLine());
            }
            catch{
                a = 0;
                b = 10;
                Console.WriteLine("Couldn't parse your input. Set a, b to default values (0, 10)");
            }
            Console.WriteLine("Recursive print:");
            recursionPrint(a, b);
            Console.WriteLine("Recursive sum: " + recursionSum(a, b));
            return 0;
        }
    }
}