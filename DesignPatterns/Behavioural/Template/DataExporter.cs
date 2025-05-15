using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Template
{
    // Abstract Class defining the Template Method
    public abstract class DataExporter
    {
        // Template Method
        public void Export()
        {
            Connect();
            FetchData();
            FormatData();
            SaveToFile();
            Disconnect();
        }

        protected abstract void Connect();
        protected abstract void FetchData();
        protected abstract void FormatData();
        protected abstract void SaveToFile();
        protected virtual void Disconnect()
        {
            Console.WriteLine("Disconnected from data source.");
        }
    }
}
