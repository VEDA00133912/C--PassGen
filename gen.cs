using System;

class Program {
    static void Main() {
        int length, count;
        string charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()";
        Random rand = new Random();

        Console.Write("桁数: ");
        if (!int.TryParse(Console.ReadLine(), out length) || length <= 0) { Console.WriteLine("有効な整数を入力してください"); return; }

        Console.Write("生成数: ");
        if (!int.TryParse(Console.ReadLine(), out count) || count <= 0) { Console.WriteLine("有効な整数を入力してください"); return; }

        for (int i = 1; i <= count; i++) {
            Console.Write($"{i}: ");
            for (int j = 0; j < length; j++) 
                Console.Write(charset[rand.Next(charset.Length)]);
            Console.WriteLine();
        }
    }
}
