using System.Collections.Generic;

public class Kennel
{
    public Animal[] _animals;
    public Dog[] _dogs;
    public Cat[] _cats;

    public Kennel()
    {
        _animals = new Animal[3];

        Dog dog1 = new Dog("Beth", 2);
        Dog dog2 = new Dog("Bob", 10);

        Cat cat1 = new Cat("Pantera", 5);

        _animals[0] = dog1;
        _animals[1] = dog2;
        _animals[2] = cat1;
    }
}
