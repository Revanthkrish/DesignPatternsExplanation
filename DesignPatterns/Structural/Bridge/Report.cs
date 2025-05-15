using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public abstract class Report
    {
        protected IReportRenderer _renderer;

        public Report(IReportRenderer renderer)
        {
            _renderer = renderer;
        }

        public abstract void Generate();
    }
}
