namespace lab4_bogdanenko
{
    class CE_user
    {
        public int Id;
        public string name;
        public string surname;
        public string position;

        public override string ToString()
        {
            return Id.ToString() + " " + name + " " + surname + " POSITION: " + position;
        }
    }
}
