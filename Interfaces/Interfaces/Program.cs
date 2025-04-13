using Interfaces;
using System;

class Program
{
    private static void Main(string[] args)
    {
        //Circle circle = new Circle(10, 14, 20);
        //circle.Draw();
        //Console.WriteLine("********************************");
        //Point point = new Point(20, 24);
        //point.Draw();
        //Console.WriteLine("********************************");
        //((IDrawShape)circle).Hello();
        //IDrawShape[] shapes = new IDrawShape[3];
        //shapes[0] = new Point(20, 34);
        //shapes[1] = new Circle(23, 43, 52);
        //shapes[2] = new Circle(20, 78, 54);

        //foreach (IDrawShape shape in shapes) { 
        //    shape.Draw();
        //}
        UserSocial userSocial = new UserSocial(41, "admin", "admin123", "Sysadmin", 42);
        Console.WriteLine(userSocial.ToString());
        Console.WriteLine("******************************************");
        userSocial.Login = "Superadmin";
        Console.WriteLine("******************************************");
        Console.WriteLine(userSocial.ToString());
    }
}