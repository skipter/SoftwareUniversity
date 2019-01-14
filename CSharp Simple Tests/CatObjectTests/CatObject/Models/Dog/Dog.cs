namespace CatObject.Models.Dog
{

    using CatObject.Models.Dog.Contracts;

    class Dog : IDog
    {

        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Bark()
        {
            return "Bark bark !!!";
        }

        public string Eat()
        {
            return "am am am";
        }

        public string Sleep()
        {
            return "ZZZzzzz dog dreams... ZZzzzz";
        }
    }
}
