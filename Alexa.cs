using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentSolutions
{
 public class Alexa
  {
    Model model = new Model();

    public Alexa()
    {
      model.OwnerName = "Alexa";
      model.GreetingMessage = "Hello, i am {name}";
    }
    public string Talk()
    {
     
      return model.Greeting();
    }

    public void Configure(Action<Model> input)
    {
      input.Invoke(model);
    }
  }

  public class Model
  {
      public string GreetingMessage { get; set; }
      public string OwnerName { get; set; }

    public string Greeting()
    {
      string text = GreetingMessage;
      int start = text.LastIndexOf("{");
      int length = text.IndexOf("}") - start;
      string sub = text.Substring(start, length + 1);
      text = text.Replace(sub, OwnerName);

      return text;
    }
  }
}
