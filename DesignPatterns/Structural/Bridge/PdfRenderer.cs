using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class PdfRenderer : IReportRenderer
    {
        public void Render(string reportName)
        {
            Console.WriteLine($"Rendering '{reportName}' report as PDF.");
        }
    }
}
