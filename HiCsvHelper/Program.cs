namespace HiCsvHelper
{
    using CsvHelper;
    using CsvHelper.Configuration;
    using System;
    using System.Globalization;
    using System.IO;

    internal class Program
    {
        private static void Main(string[] args)
        {
            StringWriter writer = new();

            CsvWriter csvWriter = new(
                writer,
                new CsvConfiguration(
                    CultureInfo.CurrentCulture));

            csvWriter.WriteHeader<ReportRecord>();

            csvWriter.NextRecord();

            csvWriter.WriteRecord(
                new ReportRecord
                {
                    Manager = "Ivan Petrov",
                    Age = 34
                });

            csvWriter.NextRecord();

            csvWriter.WriteRecord(
                new ReportRecord
                {
                    Manager = "Petr Ivanov",
                    Age = 43
                });


            csvWriter.Flush();

            Console.WriteLine(writer.ToString());
        }
    }
}