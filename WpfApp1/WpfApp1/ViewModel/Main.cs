using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModel
{
    public class Main
    {

        public string _champResult;
        public string _text;
        public string valider
        {
            get { return "valider"; }

        }
        public string champResult
        {
            get
            {
                return _champResult;
            }
            set {
                _champResult = value;
                }

        }

        public string text
        {
            get { return "Rentrer un text"; }
            set
            {
                _text = value;
            }
        }
        public string message
        {
            get { return "Avez vous compris?\nr"; }

        }

        public string message2
        {
            get { return "Bravo"; }

        }
    }
}
