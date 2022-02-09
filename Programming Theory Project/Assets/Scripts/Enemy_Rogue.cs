using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Enemy_Rogue : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        CharacterClass = "Rogue";
        Hp = 50;
        Dmg = 50;
        Def = 25;      
    }

    // POLYMORPHISM
    public override void Attack()
    {
        Debug.Log("Rogue attack: -" + Dmg + "hp");
        // ABSTRACTION
        Bleeding();
    }

    public override void Guard()
    {
        Debug.Log("Rogue parry: attack parried");
    }

    void Bleeding()
    {
        Debug.Log("Bleed damage to rogue target");
    }
}
