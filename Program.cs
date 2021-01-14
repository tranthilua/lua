using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Nhap Ten Nguoi Dung");
            Console.WriteLine("Chao mung: " +Console.ReadLine()+ " den voi mon hoc LTQL"); // in ra man hinh 1 chuoi + ten minh vua nhap
            Console.WriteLine("Giai phuong trinh bac nhat ax + b = 0:");
            Console.WriteLine("Nhap he so a:");
            string temp1 = Console.ReadLine(); // nhap tu ban phim roi gan vao bien temp1
            int a = int.Parse(temp1); // ep kieu temp1 thanh int
            Console.WriteLine("Nhap he so b:");
            string temp2 = Console.ReadLine();
            int b = int.Parse(temp2);
            int x= -b/a;
            Console.WriteLine("Phuong trinh: " + a + "x + " + b + " = 0 co nghiem la: x = " + x);
         
        }
    }
}
