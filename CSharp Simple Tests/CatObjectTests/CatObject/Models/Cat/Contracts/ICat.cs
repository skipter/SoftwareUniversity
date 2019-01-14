namespace CatObject.Models.Cat.Contracts
{
    public interface ICat
    {
        string Name { get; }

        int Age { get; }

        string Mquu();

        string Sleep();

        string Eat();
    }
}
