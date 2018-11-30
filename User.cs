using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentSolutions
{
  public class User
  {
    string path = Environment.CurrentDirectory +"/users.txt";
    public void Add(string value)
    {
      using (StreamWriter writer = new StreamWriter(path, true))
      {
        writer.WriteLine(value);
      }

    }

    public int GetUsersCount()
    {
      var value = File.ReadAllLines(path);
      return value.Length;
    }
  }
}
