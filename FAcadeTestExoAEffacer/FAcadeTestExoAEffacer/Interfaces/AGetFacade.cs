using Facade;

namespace FAcadeTestExoAEffacer
{
    public class AGetFacade
    {

        protected AGetFacade(Imenu menu, ICuisine cuisine)
        {
            _menu = menu;
            _cuisine = cuisine;

        }
        public Imenu _menu { get;private set; }
        public ICuisine _cuisine { get;private set; }
    }

}
