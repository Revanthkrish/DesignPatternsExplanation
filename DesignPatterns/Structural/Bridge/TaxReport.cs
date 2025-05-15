using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    // Tax report uses the renderer to generate output
    public class TaxReport : Report
    {
        public TaxReport(IReportRenderer renderer) : base(renderer) { }

        public override void Generate()
        {
            Console.WriteLine("Generating Tax Report...");
            _renderer.Render("Tax");
        }
    }
}
