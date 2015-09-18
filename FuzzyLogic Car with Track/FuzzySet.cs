using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic_Car_with_Track
{
    class FuzzySet
    {
        string name;
        List<FuzzySetMember> members = new List<FuzzySetMember>();

        public List<FuzzyResult> run(double value) {
            List<FuzzyResult> results = new List<FuzzyResult>();
            foreach (FuzzySetMember member in members)
            {
                if (member.inRange(value))
                    results.Add(new FuzzyResult(member.Name,member.getDegreeOfMemberShip(value)));
            }
            return results;
        }

        public void AddMember(FuzzySetMember member) { members.Add(member); }
        public void RemoveMember(FuzzySetMember member) { members.Remove(member); }

        public FuzzySetMember getMember(string name)
        {
            foreach (FuzzySetMember member in members)
                if (member.Name == name)
                    return member;
            return null;
        }

        public List<string> getMemberNames() {
            List<string> names = new List<string>();
            foreach (FuzzySetMember member in members)
                names.Add(member.Name);
            return names;
        }

        
    }
}
