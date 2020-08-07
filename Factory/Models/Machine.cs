using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Machine
    {
        public Machine()
        {
            this.Engineers = new HashSet<MachineEngineer>();
            this.Statuses = new HashSet<Status>();
        }
        public int MachineId { get; set; }
        public string MachineType { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime DateLastRepaired { get; set; }
        public ICollection<Status> Statuses { get; set; }
        public ICollection<MachineEngineer> Engineers { get; set;} 
    }
}