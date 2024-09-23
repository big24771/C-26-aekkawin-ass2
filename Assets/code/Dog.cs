using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public void Fetch()
    {
        Debug.Log($"{NameAnimal} fetch");
    }

    void Start()
    {
        //Dog
        NameAnimal = "Dog";
        Debug.Log($"Name {NameAnimal} has health: {Health}, Speed: {Speed}, Hunger: {getHunger()}");
        Eat(food[1]);
        Move();
        Sleep();

    }

    
}
