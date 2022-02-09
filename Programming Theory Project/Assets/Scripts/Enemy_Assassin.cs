using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private void OnMouseDown()
    {
        Debug.Log("HP: " + Hp + " DMG: " + Dmg + " DEF: " + Def + " Class: " + CharacterClass);
        Attack();
        Guard();
    }

    protected override void Attack()
    {
        Debug.Log("Assassin attack: -" + Dmg + "hp");
        Poison();
    }

    protected override void Guard()
    {
        Debug.Log("Assasin dodge: enemy missed");
    }

    void Poison()
    {
        Debug.Log("Poison damage to assassin target");
    }
}
