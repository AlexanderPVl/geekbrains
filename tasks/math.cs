using System;

//Author: Prikhodov Alexander.

namespace tasks {
    public static class numbers{
        public static int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }
    }

    public class complexNumber{
        private double x;
        private double y;
        public double X {
            get => x;
            set => x = value;
        }
        public double Y {
            get => y;
            set => y = value;
        }
        public complexNumber(double x_, double y_){
            x = x_;
            y = y_;
        }
        public static complexNumber operator+(complexNumber z1, complexNumber z2){
            return new complexNumber(z1.x + z2.x, z1.y + z2.y);
        }
        public static complexNumber operator-(complexNumber z1, complexNumber z2){
            return new complexNumber(z1.x - z2.x, z1.y - z2.y);
        }
        public static complexNumber operator*(complexNumber z1, complexNumber z2){
            return new complexNumber(z1.x * z2.x - z1.y * z2.y, z1.x * z2.y + z1.y * z2.x);
        }
        public static complexNumber operator/(complexNumber z1, complexNumber z2){
            return z1 * z2.inv();
        }
        public static bool operator==(complexNumber z1, complexNumber z2){
            return z1.x == z2.x && z1.y == z2.y;
        }
        public static bool operator!=(complexNumber z1, complexNumber z2){
            return !(z1 == z2);
        }
        public override bool Equals(object obj){
            complexNumber o = obj as complexNumber;
            if (o == null) return false;
            return x == o.x && y == o.y;
        }
        public override int GetHashCode(){
            return (x.ToString() + "," + y.ToString()).GetHashCode();
        }
        public static implicit operator complexNumber(double a) => new complexNumber(a, 0);
        public static implicit operator complexNumber(int a) => new complexNumber((double)a, 0);
        public bool isNull(){
            return x == 0 && y == 0;
        }
        public complexNumber conjugate(){
            return new complexNumber(x, -y);
        }
        public double norm(){
            return Math.Sqrt(x*x + y*y);
        }
        public complexNumber inv(){
            if (isNull()) {
                Console.WriteLine("complexNumber: couldn't invert 0");
                throw new Exception("complexNumber: couldn't invert 0");
            }
            return this.conjugate() * ( 1 / (Math.Pow(norm(), 2)) );
        }
        public void print(string line){
            Console.WriteLine(line + stringify());
        }
        public string stringify(){
            return $"{x} + {y}i";
        }
    }

    public class rational{
        private int a, b;
        public int A {
            get => a;
            set => a = value; 
        }
        public int B {
            get => b;
            set => b = value;
        }
        public rational(int a_, int b_){
            if (b_ == 0) {
                Console.WriteLine("rational: denominator can't be equal to 0");
                throw new ArgumentException("rational: denominator can't be equal to 0", "b_");
            }
            if (a_ == 0){
                a = 0;
                b = 1;
                return;
            }
            a = a_;
            b = b_;
            simplify();
        }
        public void simplify(){
            if (a == 0){
                b = 1;
                return; 
            }
            if (b == 0){
                a = 0;
                return;
            }
            int g = numbers.gcd(a, b);
            a /= g;
            b /= g;
        }
        public static rational mult(rational q1, rational q2){
            return new rational(q1.a * q2.a, q1.b * q2.b);
        }
        public static rational operator+(rational q1, rational q2){
            return new rational(q1.a * q2.b + q1.b * q2.a, q1.b * q2.b);
        }
        public static rational operator-(rational q1, rational q2){
            return new rational(q1.a * q2.b - q1.b * q2.a, q1.b * q2.b);
        }
        public static rational operator*(rational q1, rational q2){
            return new rational(q1.a * q2.a, q1.b * q2.b);
        }
        public static rational operator/(rational q1, rational q2){
            return rational.mult(q1, q2.inv());
        }
        public static bool operator==(rational q1, rational q2){
            return q1.a * q2.b == q1.b * q2.a;
        }
        public static bool operator!=(rational q1, rational q2){
            return q1.a * q2.b != q1.b * q2.a;
        }
        public override bool Equals(object obj){
            rational o = obj as rational;
            if (o == null) return false;
            return a * o.b == b * o.a;
        }
        public override int GetHashCode(){
            return ((double)a / (double)b).GetHashCode();
        }
        public static implicit operator rational(int a) => new rational(a, 1);
        public bool isNull(){
            return a == 0;
        }
        public rational inv(){
            if (isNull()){
                Console.WriteLine("rational: couldn't invert 0");
                throw new ArgumentException("rational: couldn't invert 0");
            }
            return new rational(b, a);
        }
        public rational abs(){
            return new rational(Math.Abs(a), Math.Abs(b));
        }
        public string stringify(){
            if (b == 1){
                return $"{a}";
            }
            return a * b >= 0 ? $"{Math.Abs(a)}/{Math.Abs(b)}" : $"-{Math.Abs(a)}/{Math.Abs(b)}";
        }
        public void print(string line = ""){
            Console.WriteLine(line + stringify());
        }
    }
}