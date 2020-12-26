namespace FacadeTest
{
    public class Importfeature 
    {
        public Geoapplication _GeoApplication { get; private set; }

        public Importfeature()
        {
            Menu menu = new Menu();
            Inspector inspector = new Inspector();
             
            Geoapplication geoApplication = new Geoapplication(menu, inspector);
            _GeoApplication = geoApplication;
        }
       
    }

}