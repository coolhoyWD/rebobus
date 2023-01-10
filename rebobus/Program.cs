using System;
using System.Runtime.Serialization.Formatters;
using System.Threading;
namespace rebobus
{ class program { static void Main(string[] args) { for (int i =1000; i > 0; i -= 7) { Console.WriteLine(i + "-" + 7 + "=" + (i - 7));
                Thread.Sleep(50);
            } } } }