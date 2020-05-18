using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
    public class UpgradeTasks : Data
    {
        public UpgradeTasks(Row row, DataTable datatable) : base(row, datatable)
        {
            LoadData(this, GetType(), row);
        }

        public  ArtoUpgradeTasks { get; set; }

        public name  { get; set; }

        public tasktype  { get; set; }

        public progresstype  { get; set; }

        public set  { get; set; }

        public tid  { get; set; }

        public iconswf  { get; set; }

        public iconexportname  { get; set; }

        public quantity  { get; set; }

        public quantity2  { get; set; }

        public data1  { get; set; }

        public data2  { get; set; }

        public disabled  { get; set; }

        public flufftid  { get; set; }
    }
}
