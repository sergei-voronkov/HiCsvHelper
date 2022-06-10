namespace HiCsvHelper
{
    using CsvHelper.Configuration.Attributes;

    public record ReportRecord
    {

        [Name("Manager First Name")]
        public string Manager { get; init; }
    
        [Name("Manager Age")]
        public int Age { get; init; }
    }

}