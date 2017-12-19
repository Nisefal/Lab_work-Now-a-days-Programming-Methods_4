namespace lab4_bogdanenko
{
    class Computing_eguipment
    {
        public int Id;
        public string name;
        public double price;
        public double computing_power;

        public override string ToString()
        {
            return Id.ToString() + " " + name + " PRICE: " + price + " POWER: " + computing_power;
        }
    }
}
