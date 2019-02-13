using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace websitecsharp.shared.orchestrators
{
   public class webapiorchestrator
    {

        public String GetInformation()
        {
            String data;

            data = "name: Ian Tibe role:  Tester, coder  e-mail: imtibe@dmacc.edu" + 
                "name: Jared Holliday role: GitHub Respository Manager, coder e-mail: jrholliday@dmacc.edu" +
                "name: Benjamin Frederickson role: Project manager, coder  email: bfrederickson@dmacc.edu";
           
            return data;
                        
        }
    }
}
