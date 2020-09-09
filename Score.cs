using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld {
  class Score : IComparable <Score>  {
    private string name = "";
    private int guess = 0;
    

    public string Name { get => name; set => name = value; }
    public int Guess { get => guess; set => guess = value; }
    
    public Score() {
      
    }

    public int CompareTo(Score other) {
      return other.Guess.CompareTo(this.Guess);
    }
  }
}
