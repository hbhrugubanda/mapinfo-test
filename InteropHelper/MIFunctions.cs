using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

//after adding miadm.dll
using MapInfo.MiPro.Interop;


namespace InteropHelper
{
    public class MIFunctions
    {
        public static void fromInteropHelper()
        {
            // 1. Do
            //Do Expression
            String doExpr = "Note \"I'm being called from C#, calling MapBasic...\"";
            InteropServices.MapInfoApplication.Do(doExpr);

            // 2. Do again.
            InteropServices.MapInfoApplication.Do("Print \"This is printed text in the MapInfo Message window\"");


            // 3. Eval
            String evalExpr = "NumTables( )";
            int numTables = Convert.ToInt32(InteropServices.MapInfoApplication.Eval(evalExpr));
            MessageBox.Show(String.Format("Num of Tables is {0}", numTables));
        }

    }
}
