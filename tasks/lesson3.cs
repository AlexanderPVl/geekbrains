using System;

//Author: Prikhodov Alexander.

namespace tasks {
    public class lesson3{

        public static int task1(){
            complexNumber z = new complexNumber(3, 5);
            complexNumber w = new complexNumber(5, -2.5);
            z.print("z = ");
            w.print("w = ");
            Console.WriteLine($"|z| = {z.norm()}");
            (z + w).print("z + w = ");
            (z + w).print("z - w = ");
            (z + w).print("z * w = ");
            (z + w).print("z / w = ");
            Console.WriteLine($"1 / z = " + (z * z.inv()).stringify());
            Console.WriteLine($"z * 2.5 = " + (z * 2.5).stringify());
            Console.WriteLine($"z - 3 = " + (z - 3).stringify());
            Console.WriteLine($"z == 3 + 5i is {z == new complexNumber(3, 5)}");
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
            Console.WriteLine($"a / 0 = {(a / 0).stringify()}");
            return 0;
        }
    }
}