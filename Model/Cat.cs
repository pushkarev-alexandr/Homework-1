namespace Domain
{
    public class Cat
    {
        private string _name;
        private int _health = 5;

        public Cat(string age)
        {
            Age = age;
            Color = new CatColor();
        }

        public string Name
        {
            get { return _name ?? "Your cat is unnamed:("; }
            set
            {
                _name = _name ?? value;
            }
        }

        public string Age { get; private set; }

        public CatColor Color { get; set; }

        public string CurrentColor
        {
            get { return _health < 5 ? Color.SickColor : Color.HealthyColor; }
        }

        public void Feed()
        {
            _health++;
        }

        public void Punish()
        {
            _health--;
        }

    }
}


