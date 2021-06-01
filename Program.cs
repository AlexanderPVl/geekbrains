using System;

// Author: Prikhodov Alexander.

namespace tasks
{
    public class authentication{
        public string login;
        public string password;
        public authentication(string _login, string _password){
            login = _login;
            password = _password;
        }
    }
    
    class Program
    {
        public static authentication auth = new authentication("root", "GeekBrains");
        static void Main(string[] args)
        {
            /*
            int i = 0;
            bool isAuthenticated = false;
            do{
                isAuthenticated = lesson2.auth(auth);
            } while(!isAuthenticated && ++i < 3);
            if (!isAuthenticated) {
                Console.WriteLine("Authentication failed");
                return;
            }
            Console.WriteLine("Authentication succeeded");
            */
            commandProcessor commProc = new commandProcessor();

            commProc.printHelp();
            do {
                Console.Write("\r\n> ");
            }
            while(commProc.processCommand(Console.ReadLine()) != commandProcessor.action.quit);
        }
    }
}
