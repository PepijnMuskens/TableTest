using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimLogic
{
    public class Table
    {
        public string Name { get; set; }
        public List<Row> Rows { get; set; }

        public Table(string name)
        {
            Name = name;
            Rows = new List<Row>();
        }

        public int AddRow(Row row)
        {
            foreach(Row row1 in Rows)
            {
                if(row1.Name == row.Name)
                {
                    return 0;
                }
            }
            Rows.Add(row);
            return 1;
        }
    }
}
