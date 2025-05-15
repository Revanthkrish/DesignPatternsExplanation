using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class ExcelRenderer : IReportRenderer
    {
        public void Render(string reportName)
        {
            Console.WriteLine($"Rendering '{reportName}' report as Excel.");
        }
    }
}
