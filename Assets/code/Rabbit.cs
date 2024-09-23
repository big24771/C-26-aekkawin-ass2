using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : Animal
{
    
    void Start()
    {
        
        
          
            //Rabbit
            NameAnimal = "Rabbit";
            Debug.Log($"Name {NameAnimal} has health: {Health}, Speed: {Speed}, Hunger: {getHunger()}");
            Eat(food[1]);
            Move();
            Sleep();

        
    }

}
