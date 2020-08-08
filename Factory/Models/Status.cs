using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Status
  {
    
    public int StatusId { get; set; }
    [DisplayName("Status Name")]
    public string StatusName { get; set; }
    [DisplayName("Date created")]
    [DataType(DataType.Date)]
    public DateTime StatusDate { get; set; }
    public byte[] StatusImage { get; set; }
    public int MachineId { get; set; }
    public Machine Machine { get; set; }
  }
}