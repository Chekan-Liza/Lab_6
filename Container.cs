using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAP_Laba_6 {
  class Bookkeeping {

    public List<Document> data = new List<Document>();
 
    public static int counter = 0;

    public void Output( ) {
      if ( counter == 0 ) {
        Console.WriteLine( "В бухгалтерии нет сведений!" );
      }
      else {
        foreach ( object i in data ) {
          Console.WriteLine( $"Объект {i}" );
        }
      }
    }

    public void Remove(Document A ) {
      data.Remove( A );
    }

    public void ClearLibrary( ) {
      if ( counter == 0 ) {
        Console.WriteLine( "Бухгалтерия пуста" );
      }
      else {
        counter = 0;
        data.Clear();
        Console.WriteLine( "Бухгалтерия очищена" );

      }
    }

    public void Push(Document N ) {
      data.Add( N );
      counter++;
    }
  }
}
