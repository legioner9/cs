// See https://aka.ms/new-console-template for more information
using System;
namespace YourNamespace
{
    class YourClass
    {
        Yanshoff y = new Yanshoff();
        y.MyValue = "this is my value!";

    y.GetType().GetProperties().ToList().ForEach(prop=>
    {
            var val = prop.GetValue(y, null);

            System.Console.WriteLine("{0} : {1}", prop.Name, val);
        });

    y.GetType().GetMethods().ToList().ForEach(meth=>
    {
            System.Console.WriteLine(meth.Name);
        }
    }

    struct YourStruct
    {
    }

    interface IYourInterface
    {
    }

    delegate int YourDelegate();

    enum YourEnum
    {
    }

    namespace YourNestedNamespace
    {
        struct YourStruct
        {
        }
    }

    public class Yanshoff
{
    public string MyValue {get; set;}

    public void MyMethod()
    {
         System.Console.WriteLine("I'm a Method!");
    }


}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
        }
    }
}
