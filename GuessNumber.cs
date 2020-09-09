using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld {
  class GuessNumber {

    private Boolean runGame = false;
    private Score gameScore;
    private Highscore scoreList = null;
    public GuessNumber() {
    }

    public void playGame(String playOption) {
      
      scoreList = new Highscore();
      Boolean playAgain = true;
      int nrOfGuess;
      int randomNum;
      int userGuess = 0;
      String userVal;
      String playerName;
      List<Score> scores = new List<Score>();

      runGame = willPlay(playOption);

      while (runGame) {
        Random random = new Random();
        randomNum = random.Next(1, 101);
        nrOfGuess = 1;
        Console.WriteLine('\n' + "Please guess a number between 1-100");
        Console.WriteLine(randomNum);
        while (userGuess != randomNum) {
          try {
            userGuess = int.Parse(Console.ReadLine());
            
          }
          catch (Exception e) {
            Console.WriteLine("Please insert a number ", e);
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
        Console.WriteLine("You guessed " + nrOfGuess + " times!");
        Console.WriteLine("Please enter your name: ");
        playerName = Console.ReadLine();
        gameScore = new Score();
        gameScore.Name = playerName;
        gameScore.Guess = nrOfGuess;
        scores.Add(gameScore);
        
       
       
        
        Console.WriteLine("Do you wish to play again? (Y/N) \n");
        userVal = Console.ReadLine();
        if (userVal.Equals("n", StringComparison.InvariantCultureIgnoreCase)) {
          runGame = false;
          scoreList.saveScore(scores);
        }
      }
    }
    private Boolean willPlay (String playOption) {
      if (playOption.Equals("ja")) {
        return true;
      }
      else {
        return false;
      }
    }
  }
}
