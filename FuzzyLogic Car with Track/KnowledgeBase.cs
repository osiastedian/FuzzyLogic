using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyLogic_Car_with_Track
{
    class KnowledgeBase
    {
        public string[] horizontalScale { get; set; }
        public string[] verticalScale { get; set; }
        string[,] knowledge = null;


        public KnowledgeBase(int rows,int cols)
        {
            horizontalScale = new string[rows];
            verticalScale = new string[cols];
            knowledge = new string[rows,cols];
        }

        public void addAndRule(string arg1, string arg2, string result)
        {

            if (!horizontalScale.Contains(arg1))
                throw new Exception("Arg1 does not exist in the horizontal scale.");
            if (!verticalScale.Contains(arg2))
                throw new Exception("Arg2 does not exist in the vertical scale.");

            int h_scale = getIndex(arg1, horizontalScale);
            int v_scale = getIndex(arg2, verticalScale);

            knowledge[h_scale,v_scale] = result;
        }

        public string getAndResult(string arg1, string arg2)
        {
            if (!horizontalScale.Contains(arg1))
                throw new Exception("Arg1 does not exist in the horizontal scale.");
            if (!verticalScale.Contains(arg2))
                throw new Exception("Arg2 does not exist in the vertical scale.");

            int h_scale = getIndex(arg1, horizontalScale);
            int v_scale = getIndex(arg2, verticalScale);
            
            return knowledge[h_scale, v_scale];
        }

        public int getIndex(string arg, string[] array)
        {
            return array.ToList().IndexOf(arg);
        }
    }
}
