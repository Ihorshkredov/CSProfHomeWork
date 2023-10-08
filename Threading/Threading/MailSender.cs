using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public static class MailSender
    {

        public static void SendMail()
        {
   
            Console.WriteLine($"Mail was sent in {Thread.CurrentThread.GetHashCode()}");
            Console.WriteLine($"We glad to inform you become part of our team.");
            Console.WriteLine($"Please connect with our HR department till next week");
            Thread.Sleep(5000);
            Console.WriteLine($"Mail sent from {Thread.CurrentThread.GetHashCode()} end sending ");
          
        }
    }
}
