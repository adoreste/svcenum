using System;
using System.ServiceProcess;

public class SvcEnum
{
    public static void Usage()
    {
        Console.WriteLine("[+] SvcEnum: Enumerate Windows Services.");
        Console.WriteLine("[>] LinkedIn: https://www.linkedin.com/in/andresdoreste/");
        Console.WriteLine("");
        Console.WriteLine("Usage:");
        Console.WriteLine("");
        Console.WriteLine(" Get all services: 'SvcEnum.exe all'");
        Console.WriteLine(" Get Services with CanStop and CanShutdown set to true: 'SvcEnum.exe canstop'");
    }

    public static void Main(string[] args)
    {
        bool canStop;
        if (args.Length == 0) { Usage(); return; }
        if (args.Length > 0)
        {
            if (args[0].ToString().ToLower() == "canstop") { canStop = true; }
            else if (args[0].ToString().ToLower() == "all") { canStop = false; }
            else { Usage(); return; }
            GetSvc(canStop);
        }
    }

    public static void GetSvc(bool canStop)
    {
        ServiceController[] services = ServiceController.GetServices();
        foreach (ServiceController service in services)
        {
            if (canStop == true)
            {
                if (service.CanStop == false || service.CanShutdown == false) { continue; }
            }
            try
            {
                Console.WriteLine("");
                Console.WriteLine("[+] Name: " + service.ServiceName);
                Console.WriteLine("    Status: " + service.Status);
                Console.WriteLine("    Can Stop: " + service.CanStop);
                Console.WriteLine("    Can Pause and Continue: " + service.CanPauseAndContinue);
                Console.WriteLine("    Can Shutdown: " + service.CanShutdown);
                Console.WriteLine("    Service Type: " + service.ServiceType);
            }
            catch (Exception e)
            {
                Console.WriteLine("[!] " + e.Message);
            }
        }
    }
}
