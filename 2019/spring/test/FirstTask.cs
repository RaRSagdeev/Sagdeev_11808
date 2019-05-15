using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace ConsoleApp5
{
    class Petya
    {
        public int Divide(int a, int b)
        {
            return b/a;
        }
    }
    class Program
    {
        static void Main()
        {
            Thread threadOne = new Thread(CheckFiles);
            Thread threadTwo = new Thread(() => CheckMethod("Divide"));
            threadOne.Start(); threadTwo.Start();
        }
        static void CheckFiles()
        {
            string path = "C:\\SemResult";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists)
            {
                Console.WriteLine("Папка не найдена");
                return;
            }
            DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();
            foreach (var directory in subDirectories)
            {
                Console.WriteLine(directory.Name);
                FileInfo[] files = directory.GetFiles();
                foreach (var file in files)
                {
                    Console.WriteLine(file.Name);
                }
            }
        }

        static void CheckMethod(string methodName)
        {
            Type type = typeof(Petya);
            object target = Activator.CreateInstance(type);
            object[] args = new object[] { 5, 10 };

            int result = (int)type.InvokeMember(methodName, BindingFlags.InvokeMethod,
            null, target, args);
            Console.WriteLine(result);
        }
    }
}
