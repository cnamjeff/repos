using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInjectionDependance
{
    interface IParamètresMonteur
    {
        ParamètresUtilisateur MonterParamètres();
         void SetUtilisateur(int utilisateurId);
        

    }
}
