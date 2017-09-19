namespace FunctionalPlay
{
    public class Band
    {
        public Band(string name, string country, bool active)
        {
            _name = name;
            _country = country;
            _active = active;
        }

        private readonly string _name;
        public string Name { get { return _name; } }

        private readonly string _country;
        public string Country { get { return _country; } }

        private readonly bool _active;
        public bool Active { get { return _active; } }

        public override string ToString()
        {
            return $"{_name}, {_country}, Active: {_active}";
        }
    }
}
