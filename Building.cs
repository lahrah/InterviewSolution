using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentSolutions
{
  public class Building
  {
    private string currentext;
    public static List<string> Actions = new List<string>();
  

    public Building()
    {
    }

    public Building AddKitchen()
    {
      Actions.Add("Kitchen");
      return new Building();
    }

    public Building AddBedroom(string text)
    {
      Actions.Add(text + " room");
      return new Building();
    }

    public Building AddBalcony()
    {
      Actions.Add("Balcony");
      return new Building();
    }

    public void Build()
    {
      currentext = (String.Join(",", Actions));
    }

    public string Describe()
    {
      return currentext;
    }
  }
}
