using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    // The implementation hierarchy: report formats
    public interface IReportRenderer
    {
        void Render(string reportName);
    }
}
