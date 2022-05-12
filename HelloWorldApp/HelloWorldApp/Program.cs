using System;// 

namespace HelloWorldApp // tham chieu den khong gian ten system
{
    internal class Program
    {
        static void Main(string[] args)// entry point : diem chay dau tien
                                        // ngam dinh void (khong void -> return )
        {
            // the Main() method can  be asynchronous
            int sum = 0;// mỗi biến cấp 1 ngăn xếp
                        // Student(class: được định nghĩa bởi user) s(obj) = new(cấp phát bộ nhớ- địa chỉ bao nhiêu cấp cho biến) student  
                        //int i =132; i is boxed
                        //object o = i; o chứa địa chỉ
                        //int j = (int)o; unboxing
            //var: implicity-typed: tự duy diễn
            //      không dùng cho class,
            //dynamic: được xác định khi runtime
            // text biểu thức diễn 
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"args[{i}]={args[i]}");
                
                sum+=int.Parse(args[i]);
                
            }
            Console.WriteLine(sum);
            Console.WriteLine("Hello World!");
        }
        // 2 khong gian co long nhau 
        //
        //

    }
}
 