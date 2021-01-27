using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace SystemInfo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine();
            Console.WriteLine("System Information \n\n");
            Console.WriteLine("MachineName: {0}\n", Environment.MachineName);
            Console.WriteLine("64 Bit operating system? : {0}\n", Environment.Is64BitOperatingSystem ? "Yes" : "No");
            Console.WriteLine("The number of processors " + "on this computer is {0}.\n", Environment.ProcessorCount);
            Console.WriteLine("SystemDirectory: {0}\n", Environment.SystemDirectory);
            Console.WriteLine("The domain name is: {0}\n", Environment.UserDomainName);
            String[] drives = Environment.GetLogicalDrives();
            Console.WriteLine("GetLogicalDrives: {0}\n", String.Join(", ", drives));
            Console.WriteLine("WorkingSet: {0}\n", Environment.WorkingSet);

            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in driveInfos)
            {
                if (driveInfo.IsReady == true)
                    Console.WriteLine("Drive {0} is present in the system.", driveInfo.Name);
                    Console.WriteLine("Drive type: {0}", driveInfo.DriveType);
                    Console.WriteLine("Available space to current user:{0} bytes", driveInfo.AvailableFreeSpace);
                Console.WriteLine("Total available space: {0} bytes", driveInfo.TotalFreeSpace);
                Console.WriteLine("Total size of drive: {0} bytes ", driveInfo.TotalSize);
            }
         }
    }
}
