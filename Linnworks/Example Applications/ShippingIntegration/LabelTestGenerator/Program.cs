using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelTestGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Image img = TemplateDriver.LabelGenerator.GenerateLabel(new List<TemplateDriver.Models.ServiceConfigItem>() {
                new TemplateDriver.Models.ServiceConfigItem(){
                    ConfigItemId = "LABELTAG",
                    SelectedValue = "Next Day"
                }
                }, "Put under the door", "CODE1", "10001", "RS 938 9012 83837 GB", @"FAO Fedor Dzjuba
City Gates,
2-4 Southgate
Chichester 
PO195DJ
United Kingdom");

            img.Save("C:\\DE_files\\image.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
