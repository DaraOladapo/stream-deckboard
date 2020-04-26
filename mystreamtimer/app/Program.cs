using System;
using System.Diagnostics;

namespace mystreamtimer.extension
{
    class Program
    {
        static void Main(string[] args)
        {
          ExecuteCommand(args[0]);
        }
        public static  void ExecuteCommand(string Command)
    {
        ProcessStartInfo ProcessInfo;
        Process Process;

        // ProcessInfo = new ProcessStartInfo("cmd.exe", "/K " + Command);
        ProcessInfo = new ProcessStartInfo(Command);
        ProcessInfo.CreateNoWindow = true;
        ProcessInfo.UseShellExecute = true;
        Process = Process.Start(ProcessInfo);
    }
    }
}
