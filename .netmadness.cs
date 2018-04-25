using System;
namespace .netmadness
{
	class net
	{
        	static void Main() 
        	{
			Console.WriteLine("Please enter your username");
			string usrname = Console.ReadLine();
			while (usrname != Tristan)
			{
			Console.WriteLine("Incorrect username, please try again.");
			Console.WriteLine("Please enter your username");
			string usrname = Console.ReadLine();
			}
			if (usrname == Tristan) 
			{
				Console.WriteLine("Authorized");
					
			}
			Console.WriteLinne("Now Please enter your password");
			string password = Console.ReadLine();
			while (password != 3adaaea64cTn2002tr)
			{
			Cosole.WriteLine("Incorrect password, please try again.");
			Console.WriteLine("Please enter your Password");
			string password = Console.ReadLine();
			}
			if (password == 3adaaea64cTn2002tr)
			{
				Console.WriteLine("You are in!!);
			}
			if (usrname == Tristan && password == 3adaaea64cTn2002tr)
			{
				Console.WriteLine("Hello, welcome to the prgram");
			}
			else 
			{
				break;
			}	
			//To terminatethe program
                	Console.WriteLine("Press any key to exit.");
                	Console.ReadKey();
        	}
	}
}