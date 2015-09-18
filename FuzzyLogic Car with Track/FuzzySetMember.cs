using System;
using System.Drawing;



namespace FuzzyLogic_Car_with_Track
{
    class FuzzySetMember
    {
        public string Name { get; set; }
        double left = 0.0f;
        public double Center { get; set; }
        double right = 0.0f;

        public FuzzySetMember(string name,double start, double center, double end)
        {
            if (center >= start && center <= end)
            {
                Center = center;
                left = start;
                right = end;
                Name = name;
            }
            else
                throw new Exception("Invalid values.");

        }
        public double getBaseLength() { return right - left; }
        public double getDegreeOfMemberShip(double value)
        {
            double halfDistance = 0.0f;
            if (Center > value) { 
                halfDistance = Center - left;
                value = value - left;
            }
            else if (Center < value) { 
                halfDistance = right - Center;
                value = right - value;
            }
            else if (Center == value)
                return 1;

            return Math.Abs(value)/halfDistance;
        }

        public double getAreaByDegree(double degree)
        {
            double baseLength = right - left;
            double t1_length = 0.0f;
            double t2_length = 0.0f;
            t1_length = (Center - left) * degree;
            t2_length = (right - Center) * degree;
            double aboveLength = baseLength - t1_length - t2_length;
            return ((aboveLength + baseLength)/2) * degree;
        }

        public bool inRange(double value)
        {
            return left <= value && right >= value;
        }

        public override bool Equals(object obj)
        {
            FuzzySetMember other;
            if (obj is FuzzySetMember)
                other = (FuzzySetMember)obj;
            else
                return false;
            return Name.Equals(other.Name);
        }
    }
}
