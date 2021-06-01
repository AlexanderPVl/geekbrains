using System;

//Author: Prikhodov Alexander.

namespace tasks {
    public class lesson3{ // complexNember and rational are defined in ./math.cs

        public static bool task1Cases(complexNumber z, complexNumber w){
            switch(UM.enter("enter an operation that you want to test (+, -, *, /, all, any button to quit)")){
                case "+":{
                    (z + w).print("z + w = ");
                    break;
                }
                case "-":{
                    (z - w).print("z - w = ");
                    break;
                }
                case "*":{
                    (z * w).print("z * w = ");
                    break;
                }
                case "/":{
                    (z / w).print("z / w = ");
                    break;
                }
                case "all":{
                    z.print("z = ");
                    w.print("w = ");
                    Console.WriteLine($"|z| = {z.norm()}");
                    (z + w).print("z + w = ");
                    (z - w).print("z - w = ");
                    (z * w).print("z * w = ");
                    (z / w).print("z / w = ");
                    Console.WriteLine($"1 / z = " + (z * z.inv()).stringify());
                    Console.WriteLine($"z * 2.5 = " + (z * 2.5).stringify());
                    Console.WriteLine($"z - 3 = " + (z - 3).stringify());
                    Console.WriteLine($"z == 3 + 5i is {z == new complexNumber(3, 5)}");
                    Console.WriteLine($"z.x = {z.X}, z.y = {z.Y}");
                    z /= 0;
                    break;
                }
                default:{
                    return false;
                }
            }
            return true;
        }

        public static int task1(){
            complexNumber z;
            complexNumber w;
            switch(UM.enter("do you want to enter complex numbers? (y/n)").ToLower()){
                case "y":{
                    double[] z_ = UM.enterDoublePair();
                    double[] w_ = UM.enterDoublePair();
                    z = new complexNumber(z_[0], z_[1]);
                    w = new complexNumber(w_[0], w_[1]);
                    break;
                }
                default:{
                    z = new complexNumber(3, 5);
                    w = new complexNumber(5, -2.5);
                    break;
                }
            }
            while(task1Cases(z, w)){}
            return 0;
        }

        public static int task2(){
            return 0;
        }

        public static int task3(){
            rational a = new rational(1, 3);
            rational b = new rational(5, 9);
            rational c = new rational(10, 18);
            (a + b).print("a + b = ");
            (a - b).print("a - b = ");
            (a * b).print("a * b = ");
            (a / b).print("a / b = ");
            Console.WriteLine($"5 / 9 == 10 / 18 is {b == c}");
            Console.WriteLine($"a - 2 = {(a - 2).stringify()}");
            Console.WriteLine($"a + 2 = {(a + 2).stringify()}");
            Console.WriteLine($"a * 2 = {(a * 2).stringify()}");
            Console.WriteLine($"a / 2 = {(a / 2).stringify()}");
            Console.WriteLine($"new rational(0, 1) == 0 is {new rational(0, 1) == 0}");
            Console.WriteLine($"decimal approximation of a equals {a.Decimal}");
            Console.WriteLine($"a / 0 = {(a / 0).stringify()}");
            return 0;
        }
    }
}