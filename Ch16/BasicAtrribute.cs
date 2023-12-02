using System;
using System.Runtime.CompilerServices;

namespace BasicAttribute
{
    public static class Trace
    {
        public static void WriteLine(string message,
            [CallerFilePath] string file = "",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member = "")
        {
            Console.WriteLine($"{file}(Line: {line}) {member}: {message}");
        }
    }
    class MyClass
    {
        [Obsolete("OldMethod는 폐기되었습니다. NewMethod()를 이용하세요.")]
        public void OldMethod()
        {
            Console.WriteLine("I`m Old");
        }

        public void NewMethod()
        {
            Console.WriteLine("I`m new");
        }
    }

    class MainApp
    {
        static void MainBasicAttribute()
        {
            MyClass obj = new MyClass();
            obj.OldMethod();
            obj.NewMethod();

            Trace.WriteLine("즐거운 프로그래밍!");
        }
    }
}