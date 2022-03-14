namespace PimLogic
{
    public class Row
    {
        public string Name { get; set; }
        public Type Type { get; set; }

        public Row(string name, Type type)
        {
            Name = name;
            Type = type;
        }
    }
}