using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public Dog(string name, int currentAge)
    {
        this.name = name;
        race = "Canis lupus familiaris";
        age = currentAge;
    }

    public void Bark()
    {
        
    }
}
