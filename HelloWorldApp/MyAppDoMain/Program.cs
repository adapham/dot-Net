using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace MyAppDoMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDomain appDomain = Thread.GetDomain();
            Console.WriteLine($"{appDomain.FriendlyName}");
            Assembly[] assembly = appDomain.GetAssemblies();
            foreach(var a in assembly)
            {
                Console.WriteLine(a.FullName);
            }
            var runningProc = Process.GetProcesses()
                .OrderBy(p => p.Id);
            foreach(var proc in runningProc)
            {
                Console.WriteLine($"{proc.Id} = {proc.ProcessName}");
            }
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            string answerFile, inutFile, outputFile;
            answerFile = @"C:\Cshap\testCases10\Q1\Q1.exe";

            process.StartInfo.Arguments = $"/C{answerFile} < "
        }
    }
}
