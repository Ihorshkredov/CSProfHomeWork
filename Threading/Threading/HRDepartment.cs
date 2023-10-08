using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public class HRDepartment
    {
        public static List<Candidate> GetListOfHiredPersons(int quote, List<Candidate> candidates)
        {
            var result = new List<Candidate>();
            for (int i = 0; i < candidates.Count; i++)
            { 
                if ((quote > 0) && (candidates[i].Expirience * 100 / candidates[i].Age > 10)) 
                {
                    result.Add(candidates[i]);
                    quote--;
                }  
            }

            return result;
        }
    }
}
