namespace AdProvider.Model
{
    public class Advertisement
    {
        public Advertisement(string productName, Rule rule)
        {
            ProductName = productName;
            Rule = rule;
        }

        public string ProductName { get; }

        public Rule Rule { get; }

        public override string ToString()
        {
            return $"{ProductName}";
        }
    }
}
