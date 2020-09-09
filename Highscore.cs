namespace HelloWorld {
  using System;
  using System.Collections.Generic;
  using System.IO;
  using System.Linq;
  using System.Text;
  class Highscore {


    private FileStream fStream;
    private StreamWriter sWriter;
    private StreamReader sReader;

    public Highscore() {

    }

    public bool saveScore(List<Score> scoreList ) {
      string path = @"C:\temp\test2.txt";
      fStream = new FileStream(path,FileMode.Append);
      sWriter = new StreamWriter(fStream);
     
        foreach (Score score in scoreList) {
          sWriter.WriteLine(score.Name);
          sWriter.WriteLine(score.Guess);
        
      }
      sWriter.Close();
      fStream.Close();

      return true;
    }
    public List<Score> printScore() {
      List<Score> tempList = new List<Score>();
      
      string path = @"C:\temp\test2.txt";
      if (File.Exists(path)) { 
      fStream = new FileStream(path, FileMode.Open);
      sReader = new StreamReader(fStream);

      string line;
      while ((line = sReader.ReadLine()) != null) {
        Score newScore = new Score();
        newScore.Name = line;
 
        newScore.Guess = int.Parse(sReader.ReadLine());
        tempList.Add(newScore);
      }

      sReader.Close();
      fStream.Close();

        //sort before return 
        tempList.Sort();
        tempList.Reverse();
      return tempList;
      }
      else {
        return tempList;
      }
    }
  }
}