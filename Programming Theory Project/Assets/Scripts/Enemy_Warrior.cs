using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Warrior : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        CharacterClass = "Warrior";
        Hp = 150;
        Dmg = 80;
        Def = 50;
    }

    private void OnMouseDown()
    {
        Debug.Log("HP: " + Hp + " DMG: " + Dmg + " DEF: " + Def + " Class: " + CharacterClass);
        Attack();
        Guard();
    }

    protected override void Attack()
    {
        Debug.Log("Warrior attack: -" + Dmg + "hp");
        Weaken();
    }

    protected override void Guard()
    {
        Debug.Log("Warrior block: 80% reduced incoming damage");
    }

    void Weaken()
    {
        Debug.Log("-20% dmg debuff to warrior target");
    }
}
