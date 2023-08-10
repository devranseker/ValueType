namespace Value_Type;
class Program
{
    static void Main(string[] args)
    {
        /*
          //Value Type
          1-> değişkenlerin değerlerini saklama ve kopyalama yöntemini belirtir.
          Değer tipi olan bir değişken,
          değerini doğrudan içerir ve değişkenin kendisi, değerini temsil eder.

          2-> örneğin sayılar (int, float, double), karakterler (char),
          mantıksal değerler (bool) gibi temel veri tipleri veya yapılar (struct) gibi karmaşık veri tipleri olabilir.

          3-> Değer tipleri, genellikle belleğin yığın (stack) bölgesinde saklanır. 
          */

        int x = 15;
        int y = x;

        Console.WriteLine("x:" + x);
        Console.WriteLine("y:" + y);

        x = 40;

        Console.WriteLine("x:" + x);
        Console.WriteLine("y:" + y);

        Console.Read();
    }
}

