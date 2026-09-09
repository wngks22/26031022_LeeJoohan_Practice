
using System.Runtime.InteropServices;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        ////키워드, 식별자 연습
        //string name = "이주한";
        //string id = "26031022";
        //string subject = "객체지향C#";
        //Console.WriteLine($"이름:{name}, id:{id}, 과목:{subject}");

        ////연산 연습
        //Console.WriteLine(10 + 2000);
        //Console.WriteLine(10 + "2000");
        //Console.WriteLine(1234 / 100);
        //Console.WriteLine(1234 % 100);

        //문자형
        //Console.WriteLine('가');
        //Console.WriteLine("\"안녕하세요\"\n반갑습니다.");
        //Console.WriteLine("안"+'녕'+'하'+'세'+'요');
        //Console.WriteLine("가"+'\uAC00');

        //변수
        //int idNumber = 26031022;
        //long gameMoney = 1000000000000000000;
        //double score = 99.9;
        //char character = 'a';
        //string message = "안녕하세요";
        //var variable = 123;
        //int? Null = null;

        //비교연산자
        //int a = 20;
        //int b = 30;
        //Console.WriteLine(a > b);
        //Console.WriteLine(!(a < b));

        //자료형의 크기
        //Console.WriteLine("char   : " + sizeof(char) + "byte");
        //Console.WriteLine("short  : " + sizeof(short) + "byte");
        //Console.WriteLine("int    : " + sizeof(int) + "byte");
        //Console.WriteLine("long   : " + sizeof(long) + "byte");
        //Console.WriteLine("float  : " + sizeof(float) + "byte");
        //Console.WriteLine("double : " + sizeof(double) + "byte");
        //Console.WriteLine("bool   : " + sizeof(bool) + "byte");

        //문자 자료형
        //char value = 'A';
        //char value1 = 'a';
        //Console.WriteLine(value + 0);
        //Console.WriteLine(value1 + 0);
        //Console.WriteLine(value+(1<<5));

        //string message = "안녕하세요 :)";
        //Console.WriteLine($"{message[0]}{message[1]}");
        //Console.WriteLine(message.Length);

        //복합 연산자
        //var a = 100;
        //a += 100; // a = a + 100;
        //a -= 100; // a = a - 100;
        //a %= 9; // a = a % 9;

        //string resDir = "resource/";
        //string texPath = resDir + "m1.png";

        //자료형 지정
        //var val1 = 0; Console.WriteLine(val1.GetType());
        //var val2 = 0.0; Console.WriteLine(val2.GetType());
        //var val3 = 0.0f; Console.WriteLine(val3.GetType());
        //var val4 = '가'; Console.WriteLine(val4.GetType());
        //var val5 = "안녕"; Console.WriteLine(val5.GetType());
        //var val6 = true; Console.WriteLine(val6.GetType());


    }
}
