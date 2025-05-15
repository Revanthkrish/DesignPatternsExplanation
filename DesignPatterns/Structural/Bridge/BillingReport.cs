using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    // Billing report uses the renderer to generate output
    public class BillingReport : Report
    {
        public BillingReport(IReportRenderer renderer) : base(renderer) { }

        public override void Generate()
        {
            Console.WriteLine("Generating Billing Report...");
            _renderer.Render("Billing");
        }
    }
}
