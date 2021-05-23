using System;

namespace tasks{
    public class UM{ //usefulMethods
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
}