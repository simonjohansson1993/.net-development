using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace HelloWorld {
  class UI  {
    private Highscore scoreList;
    private List<Score> scores;

    public UI() {

    }

    

    public string drawUI() {
      String playOption;
      scoreList = new Highscore();
      scores = new List<Score>();

      Console.Write("------------------------------");
      Console.Write("\nWELCOME TO THE GUESSING GAME!!\n");
      Console.Write("------------------------------");
      Console.Write("\nHighScore: \n");

        scores = scoreList.printScore();
        if (scores.Any()) {
        //Sort the list

        foreach (Score score in scores) {
          Console.WriteLine(score.Name + "\t" + score.Guess);
        }
      }
      else {
        Console.WriteLine("You are first to play! Play a game to get into the list!");
      }
      

      Console.WriteLine("\nVill du spela?  (ja/nej)");
      playOption = Console.ReadLine();
      return playOption;

    }
  }
}