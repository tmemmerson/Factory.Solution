using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Factory.Models
{
    public class Machine
    {
        public Machine()
        {
            this.Engineers = new HashSet<MachineEngineer>();

        }
        public int MachineId { get; set; }
        [DisplayName("Machine Type")]
        public string MachineName { get; set; }
        public ICollection<MachineEngineer> Engineers { get; set;} 
    }
}