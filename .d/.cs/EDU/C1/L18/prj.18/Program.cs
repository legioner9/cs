using System;
using System.Transactions;
using prj;


Killer klr = new("13", 23, [33, 43, 53], 34);

klr.Health = 100;
System.Console.WriteLine(klr.Health);

List<Robot> rbts = [
new("15", 25, [35, 45, 55]),
new("16", 26, [36, 46, 56]),
new("17", 27, [37, 47, 57])
];

// foreach (Robot el in rbts)
// {
//     el.prnPrm();
// }

// var listEnumerator = rbts.GetEnumerator();

// for (var i = 0; listEnumerator.MoveNext(); i++)
// {
//     Robot currRbt = listEnumerator.Current;
//     Console.WriteLine("index i = {0}", i);
//     currRbt.prnPrm();
// }

foreach (Robot el in rbts)
{
    Console.WriteLine("index i = {0}", rbts.IndexOf(el));
    el.prnPrm();
}
