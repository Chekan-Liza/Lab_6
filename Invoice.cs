using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAP_Laba_6 {
  public partial class Invoice
    {
    public bool DocConfirmed( ) {
      this.IsConfirmed = true;
      return true;
    }
  }
}
