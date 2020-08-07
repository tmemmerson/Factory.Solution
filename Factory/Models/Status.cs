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

    [DisplayName("Status Condition")]
    public string StatusCondition { get; set; }


    [DisplayName("Date Status Updated:")]
    public Data StatusUpdateDate { get; set; }

    public int MachineId { get; set; }
    public Machine Machine { get; set; }
  }
}