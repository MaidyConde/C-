using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asycAwait
{
    public class Camarero
    {
        public async Task<string> PrepararBebidaAsiync(string bebida)
        {
            Bebida nuevaBebida = new Bebida();

            string result = "";
            if (bebida=="Cerveza")
            {
                result = nuevaBebida.cerveza();
                await Task.Delay(1000);
            }else if (bebida=="Martini")
            {
                result = nuevaBebida.martini();
                await Task.Delay(2000);
            }
            return $"se ha preparado la bebida :{result}";
        }
    }
}
