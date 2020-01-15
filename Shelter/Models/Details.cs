using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Shelter.Models
{
  public class Details
  {
      public string Name { get; set; }
      public string Description { get; set; }
      public string Gender { get; set; }
      public int AdmittanceDate { get; set; }
      public string Breed { get; set; }
  }
}