using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentSolutions
{
  public class Humanoid
  {
    string skill = "";
    public Humanoid(Dancing dance)
    {
      skill = "dancing";
    }

    public Humanoid(Cooking cook)
    {
      skill = "cooking";
    }
    public Humanoid()
    {

    }

    public string ShowSkill()
    {
      if (string.IsNullOrEmpty(skill))
      {
        return "no skill is defined";
      }
      else
      {
        return skill;
      }
    }
  }

  public class Dancing
  {
  }

  public class Cooking
  {
  }
}
