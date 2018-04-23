using ex1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ex1.VidewModels
{
    public class NewCustomerViewModel
    {
    public IEnumerable<MembershipType> MembershipTypes { get; set; }
    public Customer Customer { get; set; }
    }
}