using System;
using cSharpCourse1Lib; // custom libarary, link: https://github.com/AlexanderPVl/gbLibraries/tree/master/csharpcourse1Libs
// if installed, content of task 5 might be uncommented
// all other lesson 4 tasks work without cSharpCourse1Lib

//Author: Prikhodov Alexander.


namespace tasks {
    public static class staticClass{
        public static int methodForLesson4Task1(int[] arr){ // counts number of pairs where one and only element is a multiple of 3 (task 2)
            return arrayFuncs.countPairsWhere(arr, (a, b) => a % 3 == 0 ^ b % 3 == 0);
        }
        public static int[] readIntArrayFromFile(string path, char delim){ // reads an integer array from a text file (task 2)
            if (!System.IO.File.Exists(path)) { // case of missing file (task 2)
                Console.WriteLine("No file found at " + path);
                return null;
            }
            string[] data = System.IO.File.ReadAllText(path).Split(delim);
            return Array.ConvertAll(data, a => int.Parse(a));
        }
    }

    public class lesson4{
        public static int task1(){
            int N = 20, l = -10000, r = 10001, counter = 0;
            int[] arr;
            Random rand = new Random();
            arrayFuncs.fillArray(out arr, N, (i) => rand.Next(l, r));
            arrayFuncs.print(arr, "array: ");
            counter = arrayFuncs.countPairsWhere(arr, (a, b) => { return a % 3 == 0 ^ b % 3 == 0; }); // counting without staticClass
            Console.WriteLine($"cnt = {counter}");
            return 0;
        }

        public static int task2(){
            // a
            int l = -10000, r = 10001, N = 20;
            int[] arr;
            Random rand = new Random();
            arrayFuncs.fillArray(out arr, N, (i) => rand.Next(l, r)); // filling with random numbers
            Console.WriteLine("a)\r\ncnt = " + staticClass.methodForLesson4Task1(arr)); // counting with a method from staticClass

            // b
            arrayFuncs.print(staticClass.readIntArrayFromFile("./dataFiles/array.txt", ' '), "parsed array = ");
            return 0;
        }

        public static int task3(){
            // a, b
            intArray1D intArr = new intArray1D(0, 3, 5);
            intArr.print("intArr = ");
            Console.WriteLine($"sum(intArr) = {intArr.Sum}");
            arrayFuncs.print(intArr.inverse(), "intArr.inverse() = ");
            intArr.multi(2);
            intArr.print("intArr after multi(2) = ");
            Console.WriteLine($"Number of max elements in intArr = {intArr.maxCount()}");
            
            // b
            intArray1D intArrLib = new intArray1D(0, 2, 10);
            intArrLib.print("intArrLib = ");

            return 0;
        }

        public static int task4(){
            return 0;
        }

        public static int task5(){
            // a
            Console.WriteLine("task5 content is commented out due to the fact that the project couldn't run otherwise without cSharpCourse1Lib library installed");
            Console.WriteLine("Link to the library: https://github.com/AlexanderPVl/gbLibraries/tree/master/csharpcourse1Libs");
            
            intArray2D arr = new intArray2D(4, 5, 100);
            arr.print();
            Console.WriteLine($"Sum of all elements = {arr.sum()}");
            Console.WriteLine($"Sum of all elements more than 0 = {arr.sumWhere(a => a > 0)}");
            
            return 0;
        }
    }
}
