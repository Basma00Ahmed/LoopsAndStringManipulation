namespace LoopsAndStringManipulation
{/// <summary>
/// Person model class
/// </summary>
    internal class Person
    {

        public int Age { get; }
        public int Price { get; }

        public Person(int age, int price)
        {
            this.Age = age;
            this.Price = price;
        }
    }
}