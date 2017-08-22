using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiAgro.Manager
{
    public class Enums
    {
       
    }
    public enum StatusEnum
    {
        active = 1,
        inactive = 2,
        firstcall = 3,
        blacklist = 4
    }

    public enum TicketStatusEnum
    {
        Open = 1,
        Close = 2,
        Feedback = 3,
        Anonymous = 4,
        Advisory = 5,
        Visit = 6
    }
    public enum SearchCriterias
    { 
        single = 1,
        multiple =2,
        all=3
    }
   
}
