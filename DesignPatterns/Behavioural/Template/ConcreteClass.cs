using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Template
{
    // Concrete Class 1
    public class SQLDataExporter : DataExporter
    {
        protected override void Connect()
        {
            Console.WriteLine("Connected to SQL Database.");
        }

        protected override void FetchData()
        {
            Console.WriteLine("Fetched data from SQL table.");
        }

        protected override void FormatData()
        {
            Console.WriteLine("Formatted data as CSV.");
        }

        protected override void SaveToFile()
        {
            Console.WriteLine("Saved CSV to disk from SQL data.");
        }
    }

    // Concrete Class 2
    public class APIDataExporter : DataExporter
    {
        protected override void Connect()
        {
            Console.WriteLine("Connected to REST API.");
        }

        protected override void FetchData()
        {
            Console.WriteLine("Fetched data from API endpoint.");
        }

        protected override void FormatData()
        {
            Console.WriteLine("Formatted data as JSON.");
        }

        protected override void SaveToFile()
        {
            Console.WriteLine("Saved JSON to disk from API data.");
        }
    }
}
