namespace Builder.Hamburger
{
    public class ClassicHamburger : IBuilder
    {
        private Hamburger _hamburger;

        public void AddIngredients()
        {
            _hamburger.Ingredients = new[] {"Bread", "Meat", "Tomato", "Salad", "Mayonnaise"};
        }

        public void AddShape()
        {
            _hamburger.Shape = "Kite";
        }

        public void AddSize()
        {
            _hamburger.Size = 10; //inches
        }

        public void Reset()
        {
            _hamburger = new Hamburger();
        }

        public Hamburger Build()
        {
            return _hamburger;
        }
    }
}