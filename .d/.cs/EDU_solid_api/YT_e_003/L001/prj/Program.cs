// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Xarial.XCad.Documents;
using Xarial.XCad.Documents.Enums;
using Xarial.XCad.Documents.Structures;
using Xarial.XCad.Enums;
using Xarial.XCad.SolidWorks;
using Xarial.XCad.SolidWorks.Documents;
using Xarial.XCad.SolidWorks.Enums;

namespace model_generator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (VariantType app = await SwApplication.Start())
            {
                // app.ShowMessageBox("Hello World)!&");
                Console.WriteLine("Text)))");
            }
            // Console.WriteLine("Text)))");
            
        }
    }
}