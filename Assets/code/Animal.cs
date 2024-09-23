using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class Animal : MonoBehaviour
{
    //Name
    public string NameAnimal { get; set;}
    
    //Hp
    public int Health = 10;
    public int Hp { get { return Health; } set { Hp = Health; } }

    //Food
    protected string[] food = {"Meat" , "Plant" };

    //Speed
    public float Speed1 = 3f;
    public float Speed { get { return Speed1; } private set { Speed = Speed1; } }

    //Huger
    private float hunger;

    protected float getHunger()
    { 
        return hunger;
    
    }

    private void setHunger (float animalHunger)
    {
        animalHunger = 0;
        animalHunger = hunger;
    }

    //void 
    public void Eat(string food)
    {
        Debug.Log($"{NameAnimal} Eat {food}.");
    }
    public void Move()
    {
        Debug.Log($"{NameAnimal} Move.");
    }
    public void Sleep()
    {
        Debug.Log($"{NameAnimal} Sleep.");
    }



}
