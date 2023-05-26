using lastone.models;
using lastone.models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastone.repositories.Repos
{
    public interface IGlobalRepository
    {
        List<Country> GetCountries();
        List<Subject> GetSubjects();
        List<State> GetStates(int countryID);
        List<City> GetCities(int countryID, int stateID);
    }
}
