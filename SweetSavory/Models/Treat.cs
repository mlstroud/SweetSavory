using System.Collections.Generic;

namespace SweetSavory.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }

    public ICollection<FlavorTreat> Flavors { get; set; }

    public Treat()
    {
      this.Flavors = new HashSet<FlavorTreat>();
    }
  }
}