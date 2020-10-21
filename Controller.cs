using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAP_Laba_6 {
  static class Controller {

    public static void DisplayByDate(Bookkeeping obj ) {
      var display = from i in obj.data
                    orderby i.date
                    select i;

      Console.Write( "Введите желаемую дату: " );
      int useryear = Convert.ToInt32( Console.ReadLine() );

      foreach (Document i in display ) {
        if (i.date <= useryear ) {
          Console.WriteLine( i.name );
        }
      }
    }

    public static void CheckCount(Bookkeeping obj ) {
      var check = from i in obj.data
                   orderby i.TypeDoc()
                   select i;
      int count = 0;
      foreach(Document i in check) {
        if ( i.TypeDoc() == "Чек бумажный." || i.TypeDoc() == "Чек электронный." ) {
          count++;
        }
      }
      Console.WriteLine( $"Количество чеков составляет: {count}." );
    }

    public static void CostInvoice(Bookkeeping obj ) {
      var costInv= from i in obj.data
                     orderby i.cost
                     select i;

      int summ = 0;
      
      Console.Write("Введите тип документа: ");
      string user_o_name = Convert.ToString(Console.ReadLine());

      foreach (Document i in costInv ) {
                if (i.name== user_o_name) {
               summ += i.cost; 
                }
      }
      Console.WriteLine( $"Общая стоимость по типу: {summ}" );
    }
  }
}
