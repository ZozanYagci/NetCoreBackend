using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
    public class BusinessRules   // bu class çıplak ama overdesign (aşırı tasarıma) gerek yok.
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach(var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
