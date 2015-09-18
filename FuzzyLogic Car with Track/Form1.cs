using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyLogic_Car_with_Track
{
    public partial class Form1 : Form
    {
        FuzzySet temperature;
        FuzzySet waterLevel;
        FuzzySet heatKnob;
        KnowledgeBase knowledge;
        public Form1()
        {
            InitializeComponent();

            temperature = new FuzzySet();
            temperature.AddMember(new FuzzySetMember("COLD",0,30,50));
            temperature.AddMember(new FuzzySetMember("WARM", 40, 60, 80));
            temperature.AddMember(new FuzzySetMember("HOT", 70, 85, 100));

            waterLevel = new FuzzySet();
            waterLevel.AddMember(new FuzzySetMember("LOW", 0, 2, 4));
            waterLevel.AddMember(new FuzzySetMember("MEDIUM", 3, 6, 8));
            waterLevel.AddMember(new FuzzySetMember("HIGH", 7, 9, 10));

            heatKnob = new FuzzySet();
            heatKnob.AddMember(new FuzzySetMember("LITTLE",0,0,3));
            heatKnob.AddMember(new FuzzySetMember("MEDIUM", 2, 5, 8));
            heatKnob.AddMember(new FuzzySetMember("HIGH", 7, 8.5, 10));

            knowledge = new KnowledgeBase(3, 3);
            knowledge.horizontalScale = temperature.getMemberNames().ToArray();
            knowledge.verticalScale = waterLevel.getMemberNames().ToArray();
            knowledge.addAndRule("COLD", "LOW"    ,  "MEDIUM");
            knowledge.addAndRule("COLD", "MEDIUM" ,  "HIGH");
            knowledge.addAndRule("COLD", "HIGH"   ,  "HIGH");
            knowledge.addAndRule("WARM", "LOW"    ,  "LITTLE");
            knowledge.addAndRule("WARM", "MEDIUM" ,  "MEDIUM");
            knowledge.addAndRule("WARM", "HIGH"   ,  "MEDIUM");
            knowledge.addAndRule("HOT" , "LOW"    ,  "LITTLE");
            knowledge.addAndRule("HOT" , "MEDIUM" ,  "LITTLE");
            knowledge.addAndRule("HOT" , "HIGH"   ,  "LITTLE");

            temperatureTrackBar.Value = 75;
            waterLevelTrackbar.Value = 3;
            heatKnobLabel.Text = "MEAN VALUE:" + compute();
        }

        private void temperatureTrackBar_ValueChanged(object sender, EventArgs e)
        {
            temperatureLabel.Text = "Temperature = " + temperatureTrackBar.Value + " C";
            double value = compute(); 
            heatKnobLabel.Text = "MEAN VALUE:" + value; 
        }

        private void waterLevelTrackbar_ValueChanged(object sender, EventArgs e)
        {
            waterLevelLabel.Text = "Water Level = " + waterLevelTrackbar.Value + " L";
            double value = compute();
            heatKnobLabel.Text = "MEAN VALUE:" + value;
        }

        private double compute()
        {
            
            int temperature = temperatureTrackBar.Value;
            int waterLevel = waterLevelTrackbar.Value;

            List<FuzzyResult> temperatureResults = this.temperature.run(temperature);
            List<FuzzyResult> waterLevelResults = this.waterLevel.run(waterLevel);
            double numerator = 0.0f;
            double denominator = 0.0f;
            for (int i = 0; i < temperatureResults.Count; i++)
                for (int j = 0; j < waterLevelResults.Count; j++)
                {
                    string result = knowledge.getAndResult(
                                    temperatureResults[i].MemberName,
                                    waterLevelResults[j].MemberName
                                    );
                    statusLabel.Text = result;
                    FuzzySetMember  member =  heatKnob.getMember(result);
                    double degree1 = temperatureResults[i].DegreeOfMemmbership;
                    double degree2 = waterLevelResults[j].DegreeOfMemmbership;
                    double area = member.getAreaByDegree(
                        degree1 < degree2?
                            degree1 : degree2
                        );
                    double center = member.Center == 0 ? member.getBaseLength() / 3 : member.Center;
                    numerator += (area * center);
                    denominator += area;
                }
            double val = numerator / denominator;
            return  val;
        }
    }
}
