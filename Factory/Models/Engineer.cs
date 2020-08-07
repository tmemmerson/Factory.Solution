using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Engineer
    {
      public Engineer()
      {
          this.Machines = new HashSet<MachineEngineer>();
      }

      public int EngineerId { get; set; }
      public string EngineerName { get; set; }
      public string EngineerDescription { get; set; }
      [DataType(DataType.Date)]
      public DateTime EngineerHireDate { get; set; }
      
      public virtual ICollection<MachineEngineer> Machines { get; set; }
    }
}