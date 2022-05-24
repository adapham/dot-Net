using System;// 

namespace HelloWorldApp // tham chieu den khong gian ten system
{
    internal class Program
    {
        static void Main(string[] args)// entry point : diem chay dau tien
                                       // ngam dinh void (khong void -> return )
        {
            int a, b, sum;
            a = 10;
            b = 20;
            // the Main() method can  be asynchronous 
             sum = 0;// mỗi biến cấp 1 ngăn xếp
                        // Student(class: được định nghĩa bởi user) s(obj) = new(cấp phát bộ nhớ- địa chỉ bao nhiêu cấp cho biến) student  
                        //int i =132; i is boxed
                        //object o = i; o chứa địa chỉ
                        //int j = (int)o; unboxing
                        //var: implicity-typed: tự duy diễn
                        //     không dùng cho class,
                        //dynamic: được xác định khi runtime
                        // text biểu thức diễn 
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"args[{i}]={args[i]}");

                sum += int.Parse(args[i]);

            }
            Console.WriteLine(sum);
            Console.WriteLine("Hello World!");
        }
        // 2 khong gian co long nhau 
        // ref,out: truyền địa chỉ 
        //ref phải khởi động giá trị;
        //out: thì ko cần trong gọi hàm nhưng trong hàm phải đặt value
        // 
        //params: có thể truyền giá trị mảng
        //hàm cục bộ local function(chỉ có 1 mình dùng): hàm trong hàm, nếu có thêm static thì không truy cập đc value ngoài
        // TUPLES: trả về nhiều kiểu dữ liệu: var(sum,count)
        // discards:  _ 
        //NULL-Condition Operator
       

    }
}