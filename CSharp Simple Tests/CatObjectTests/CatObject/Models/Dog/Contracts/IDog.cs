namespace CatObject.Models.Dog.Contracts
{
    public interface IDog
    {
        string Name { get; }

         int Age { get; }

        string Bark();

        string Sleep();

        string Eat();
    }
}
