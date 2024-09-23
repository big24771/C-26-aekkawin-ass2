using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class Cat : Animal
{

    //spacialaction
    public void Climb()
    {
        Debug.Log($"{NameAnimal} Climb");
    }


    //normallaction
    void Start()
    {
        NameAnimal = "Cat";
        //Cat
        Debug.Log($"Name {NameAnimal} has health: {Health}, Speed: {Speed}, Hunger: {getHunger()}");
        Eat(food[0]);
        Move();
        Sleep();

    }


}
