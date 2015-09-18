using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic_Car_with_Track
{
    class FuzzyResult
    {
        public string MemberName { get; set; }
        public double DegreeOfMemmbership { get; set; }

        public FuzzyResult(string name, double degree)
        {
            MemberName = name;
            DegreeOfMemmbership = degree;
        }
    }
}
