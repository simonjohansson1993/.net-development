using System;
using System.Collections.Generic;

namespace HelloWorld {
  class Program {

    static void Main(string[] args) {
      //------------Variables---------------
      Boolean playAgain = true;
      int nrOfGuess;
      int randomNum;
      int userGuess = 0;
      String userVal;
      List<int> scores = new List<int>();
      //-------------------------------------

      Console.Write("------------------------------");
      Console.Write("\nWELCOME TO THE GUESSING GAME!!\n");
      Console.Write("------------------------------");
      
      //game loop run until user decide to quit
      do {
        Random random = new Random();
        randomNum = random.Next(1, 101);
        nrOfGuess = 1;
        Console.WriteLine('\n' + "Please guess a number between 1-100");
        //Console.WriteLine("\n" + randomNum);

        while (userGuess != randomNum) {
          try { 
          userGuess = int.Parse(Console.ReadLine()); 
          }
          catch (Exception e) {
            Console.WriteLine("Please insert a number ",e);
          }
          if (userGuess > randomNum) {
            Console.WriteLine("Wrong! " + userGuess + " is greater than my number ");
            nrOfGuess++;
          }
          else if (userGuess < randomNum) {
            Console.WriteLine("Wrong! " + userGuess + " is lower than my number ");
            nrOfGuess++;
          }
          else {
            Console.WriteLine("Congratulations! " + userGuess + " is the correct number\n");
          }
        }
        scores.Add(nrOfGuess);
        Console.WriteLine("You guessed " + nrOfGuess + " times!");
        Console.Write("Do you wish to play again? (Y/N) \n");
        userVal = Console.ReadLine();
        
        if (userVal.Equals("n", StringComparison.InvariantCultureIgnoreCase)) {
          playAgain = false;
        }  
      }
      while (playAgain);
      Console.WriteLine("\n------------------------");
      Console.Write("Your score is: ");
      foreach (int score in scores) {
        Console.Write(score + ", ");
      }
    }
  }
}
      

