using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BTDictionary
{
    //Count Thuộc tính cho biết số phần tử
    //[key]   Indexer truy cập đến phần tử có key
    //Keys Thuộc tính là danh sách các key
    //Values Thuộc tính lấy danh sách các giá trị
    //Add(key, value) Thêm một phần tử vào Dictionary
    //Remove(key) Xóa phần tử bằng key của nó
    //Clear() Loại bỏ tất cả các phần tử
    //ContainKey(key) Kiểm tra có phần tử nào có khóa là key
    //ContainValue(value) Kiểm tra có phần tử nào có giá trị là value 
    internal class Program
    {
        public static void MyDic()
        {
            // Khởi tạo với 2 phần tử
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                ["English"] = "Vietname"
            };
            // Thêm hoặc cập nhật
            dic.Add("Apple", "Quả táo");
            dic.Add("Orange", "Quả cam");
            dic.Add("Potato", "Khoai tây"); 
            dic.Add("Sweet Potato", " Khoai lang");
            dic.Add("Coconut", "Quả dừa");
            dic.Add("Pineapple", "Quả dứa");
            Console.OutputEncoding = Encoding.UTF8;
            var keys = dic.Keys;
            while (true) {
                Console.Write("Enter English word (Empty to exit):");
                string input = Console.ReadLine();
                if (dic.ContainsKey(input))
                {
                    //Console.WriteLine($"{i} = {value}");
                    Console.WriteLine($"Vietnamese word:{dic[input]}" );
                }
                if (input.Equals("")) break;
            }
            //do
            //{
            //    Console.Write("Enter English word (Empty to exit): ");
            //    input = Console.ReadLine();
            //    if (trans.TryGetValue(input, out value))
            //    {
            //        Console.WriteLine($"Vietnamese word: {value}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Don't have that word ");
            //    }
            //} while (input.Length != 0);
        }
        static void Main(string[] args)
        {
            MyDic();
        }
    }
}
