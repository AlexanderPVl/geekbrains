using System;

namespace tasks{
    public class account{
        private string login, password;
        account(string login_, string password_){
            login = login_;
            password = password_;
        }
    }

    public class UM{ //usefulMethods
        public delegate TResult Func<out TResult>();

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

        public static double[] enterDoublePair(string str = "Enter a double pair: "){
            Console.WriteLine(str);
            try{
                string[] input = Console.ReadLine().Split(' ');
                return new double[]{double.Parse(input[0]), double.Parse(input[1])};
            }
            catch{
                Console.WriteLine("Couldn't parse your input");
            }
            return new double[]{0, 0};
        }

        public static int countWhere<T>(ref T[] arr, Func<T, T, bool> pred){
            int cnt = 0;
            for (int i = 0; i < arr.Length - 1; ++i){
                if (pred(arr[i], arr[i + 1])) ++cnt;
            }
            return cnt;
        }
    }
}