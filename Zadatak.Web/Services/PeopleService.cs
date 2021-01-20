using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak.Model;
using Zadatak.Web.Mappers;
using Zadatak.Web.Models;

namespace Zadatak.Web.Services
{
    public class PeopleService
    {
        public List<Person> ReadCSVFile(string location)
        {
            try
            {
                using (var reader = new StreamReader(location, Encoding.GetEncoding("ISO-8859-2")))
                using (var csv = new CsvReader(reader))
                {
                    csv.Configuration.RegisterClassMap<PeopleMap>();
                    var records = csv.GetRecords<Person>().ToList();
                    return records;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
