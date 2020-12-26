using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInjectionDependance
{
    class CalculateurService
    {

        private IParamètresMonteur _paramètresMonteur;
        //public ParamètresMonteur ParamètresMonteur;

        //{
        //    set { this._paramètresMonteur = value; }
        //}

        public CalculateurService(IParamètresMonteur paramètresMonteur)

        {

            this._paramètresMonteur = paramètresMonteur;

        }

        public ParamètresUtilisateur ObtenirParamètres(int utilisateurId)

        {
            _paramètresMonteur.SetUtilisateur(utilisateurId);
            return _paramètresMonteur.MonterParamètres();
        }
    }
}
