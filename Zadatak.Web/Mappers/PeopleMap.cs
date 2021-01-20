using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadatak.Model;
using Zadatak.Web.Models;

namespace Zadatak.Web.Mappers
{
    public class PeopleMap : ClassMap<Person>
    {
        public PeopleMap()
        {
            Map(x => x.FirstName).Name("FirstName");
            Map(x => x.LastName).Name("LastName");
            Map(x => x.CityName).Name("CityName");
            Map(x => x.PostalCode).Name("PostalCode");
            Map(x => x.MobileNumber).Name("MobileNumber");
        }
    }
}
