namespace Labb_1___OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {                        
                Circle circle1 = new Circle(5);
                circle1.getArea();
                circle1.getOmkrets();
            
                Circle circle2 = new Circle(6);
                circle2.getArea();
                circle2.getOmkrets();            
        }        
    }    
}