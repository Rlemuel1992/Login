using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Login
{
	class Program
	{
		static List<string> emailList = new List<string>();
		static List<string> passwordList = new List<string>();

		public static void Main()
		{

			Console.WriteLine("Would you like to log in, or register? please type login, or register.");
			string decide = Console.ReadLine().ToLower();
			if (decide == "login")
			{
				Console.WriteLine("That's not coded yet! Or maybe ever....");
				Main();
			}

			else if (decide == "register")
			{
				Console.WriteLine("Alright, let's get some info first!");
			}

			else
			{
				Console.WriteLine("sorry, didn't catch that. try again with 'login or register'");
				Main();
			}

		
			Console.WriteLine("Please register a valid email address.");
			bool cont = true;
			while (cont == true)
			{


				string input = Console.ReadLine();
				bool emailValid = ValidEmail(input);
				if (emailValid == true)
				{
					Console.WriteLine("Valid email");
					emailList.Add(input);
					cont = false;
				}

				else if (emailValid == false)
				{
					Console.WriteLine("Invalid email address");
					cont = true;
				}

			}

			Console.WriteLine("Please input a valid password. \n" +
				"A password must have at least one uppercase letter have a number, " +
				"and be 5 or more characters long.");
			bool cont2 = true;
			while (cont2 == true)
			{


				string passInput = Console.ReadLine();
				bool passValid = ValidPassword(passInput);
				if (passValid == true)
				{
					Console.WriteLine("Valid password!");
					passwordList.Add(passInput);
					cont2 = false;
				}

				else if (passValid == false)
				{
					Console.WriteLine("Invalid password, try again");
					cont2 = true;
				}
			}
				Console.WriteLine("Your information stored, please log in from the main menu");
				Main();

			
		
		}



		public static bool ValidEmail(string input)
		{
			Regex email = new Regex("^[a-zA-Z0-9]{3,20}[@][a-zA-Z]{3,10}[.][a-zA-Z]{2,3}$");
			return email.IsMatch(input);

		}

		public static bool ValidPassword(string passInput)
		{
			Regex password = new Regex("^(?=.*[1-9])(?=.*[A-Z]+[a-z]).{5,15}$");
			return password.IsMatch(passInput);

		}
	}

}

