using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected int hp = 50;
    public int Hp { get; protected set; }
    protected int dmg = 50; 
    public int Dmg { get; protected set; }
    protected int def = 50;
    public int Def { get; protected set; }
    private string characterClass = "class";
    public string CharacterClass {
        get { return characterClass; }
        set { if (!Regex.IsMatch(value, @"^[a-zA-Z]+$")) 
            {
                Debug.LogError("You can only use letters in class names");
            }
            else
            {
                characterClass = value;
            }
        } 
    }

    protected virtual void Attack()
    {
        Debug.Log("Generic attack: -" + dmg);
    }

    protected virtual void Guard()
    {
        Debug.Log("Generic guard");
    }
}
