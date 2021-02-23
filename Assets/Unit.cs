using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string dinoName;
    public int dinoLevel;
    public int maxHP = 10;
    public int currentHP = 10;
    public int attack = 1;


    public bool Damage(int dmg)
    {
        currentHP -= dmg;

        if(currentHP <= 0)
        {
            return true;
        }

        return false;
    }
}
