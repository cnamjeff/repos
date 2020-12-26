using System;
using System.Collections.Generic;
using System.Text;

namespace b
{
    
    public class InitialisationObjet : ObjetVélo
    {
        public static InitialisationObjet moto = new InitialisationObjet("gsxr",25 );
        public static InitialisationObjet velo = new InitialisationObjet("yamaha",32 );

        public InitialisationObjet(string name, int number) : base(name, number)
        {
        }
  
    }
}
