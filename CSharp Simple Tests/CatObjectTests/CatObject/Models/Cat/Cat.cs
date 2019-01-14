namespace CatObject.Models.Cat
{
    using CatObject.Models.Cat.Contracts;

    public class Cat : ICat
    {

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Eat()
        {
            return "am am am";
        }

        public string Mquu()
        {
            return "Mquu mquu";
        }

        public string Sleep()
        {
            return "ZZZzzzz cat dreams... ZZzzzz";
        }
    }
}
