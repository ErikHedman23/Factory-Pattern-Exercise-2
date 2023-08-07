using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class DataAccessFactory 
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch(databaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();
                case "sql":
                    return new SQLDataBase();
                case "mongo":
                    return new MongoDataBase();
                default:
                    return new ListDataAccess();
            }
        }
    }
}
