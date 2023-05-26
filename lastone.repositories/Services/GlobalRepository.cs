using lastone.models;
using lastone.models.DBModels;
using lastone.repositories.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastone.repositories.Services
{
    public class GlobalRepository : IGlobalRepository
    {
        public List<Country> GetCountries()
        {
            AP351AteetPrajapatiEntities db = new AP351AteetPrajapatiEntities();
            return db.Countries.ToList();
        }
        public List<Subject> GetSubjects()
        {
            AP351AteetPrajapatiEntities db = new AP351AteetPrajapatiEntities();
            return db.Subjects.ToList();
        }
        public List<State> GetStates(int countryID)
        {
            AP351AteetPrajapatiEntities db = new AP351AteetPrajapatiEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return db.States.ToList().FindAll(x => x.CountryId == countryID);
        }
        public List<City> GetCities(int countryID, int stateID)
        {
            AP351AteetPrajapatiEntities db = new AP351AteetPrajapatiEntities();
            return db.Cities.ToList().FindAll(x => x.CountryID == countryID && x.StateID == stateID);
        }
    }
}
