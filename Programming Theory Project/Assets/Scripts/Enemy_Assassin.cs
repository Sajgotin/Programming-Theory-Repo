using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Enemy_Assassin : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        CharacterClass = "Assassin";
        Hp = 30;
        Dmg = 120;
        Def = 10;
    }

    // POLYMORPHISM
    public override void Attack()
    {
        Debug.Log("Assassin attack: -" + Dmg + "hp");
        // ABSTRACTION
        Poison();
    }

    public override void Guard()
    {
        Debug.Log("Assasin dodge: enemy missed");
    }

    void Poison()
    {
        Debug.Log("Poison damage to assassin target");
    }
}
