using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("This program will help you to do the convertions between Celsius and Fahrenheit.\n");
    Console.WriteLine("Convert Celsius to Fahrenheit. (X/x)");
    Console.WriteLine("Convert Fahrenheit to Celsius. (Y/y)\n");
    bool stopProgram = false;
    while(!stopProgram) {
      Console.Write("Please enter your command [x/y]: ");
      string convertionCommand = Console.ReadLine();
      if(convertionCommand == "X" || convertionCommand == "x") {
        Console.Write("Celsius: ");
        string celsiusValue = Console.ReadLine();
        double celsiusDegree = Convert.ToDouble(celsiusValue);
        if(celsiusDegree >= -273.15) {
          Console.Write("Fahrenheit: ");
          Console.WriteLine((celsiusDegree * 9 / 5) + 32);
        } else {
          absoluteZeroWarning();
        }
      } else if(convertionCommand == "Y" || convertionCommand == "y") {
        Console.Write("Fahrenheit: ");
        string fahrenheitValue = Console.ReadLine();
        double fahrenheitDegree = Convert.ToDouble(fahrenheitValue);
        if(fahrenheitDegree >= -459.67) {
          Console.Write("Celsius: ");
          Console.WriteLine((fahrenheitDegree - 32) * 5 / 9);
        } else {
          absoluteZeroWarning();
        }
      } else {
        Console.WriteLine("Invalid command!\n");
      }
      bool continuationPrompt = true;
      while(continuationPrompt) {
        Console.Write("Do you want to continue calculating the temperature conversions? [y/N] ");
        string continueCommand = Console.ReadLine();
        if(continueCommand == "Y" || continueCommand == "y") {
          stopProgram = false;
          continuationPrompt = false;
        } else if(continueCommand == "N" || continueCommand == "n" || continueCommand == "") {
          stopProgram = true;
          continuationPrompt = false;
        } else {
          continuationPrompt = true;
          Console.WriteLine("Invalid command!");
        }
      }
    }
    Console.WriteLine("\nThank you for using!");
    Console.WriteLine("Copyright (C) <2020> <Yiyu Zhou>");
    Console.WriteLine("All rights reserved.");
  }
  public static void absoluteZeroWarning() {
    Console.WriteLine("Error! The temperature you entered is below Absolute Zero.");
  }
}