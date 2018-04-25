using System;
namespace .netmadness
{
	class net
	{
        	static void Main() 
        	{
			Console.WriteLine("Please enter your username");
			string usrname = Console.ReadLine();
			while (usrname != username)
			{
			Console.WriteLine("Incorrect username, please try again.");
			Console.WriteLine("Please enter your username");
			string usrname = Console.ReadLine();
			}
			if (usrname == username) 
			{
				Console.WriteLine("Authorized");
					
			}
			Console.WriteLinne("Now Please enter your password");
			string password = Console.ReadLine();
			while (password != password)
			{
			Cosole.WriteLine("Incorrect password, please try again.");
			Console.WriteLine("Please enter your Password");
			string password = Console.ReadLine();
			}
			if (password == password)
			{
				Console.WriteLine("You are in!!);
			}
			if (usrname == username && password == password)
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
