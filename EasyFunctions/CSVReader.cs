
using System.Data;
using System.Data.OleDb;

namespace EasyFunctions
{
    public class CSVReader
    {
        public void ImportCsvFile(string filename)
        {
            var Lines = File.ReadLines(filename).Select(a => a.Split(';'));
        //    var CSV = from line in Lines
        //              select (line.Split(',')).ToArray();
        }
    }
}
