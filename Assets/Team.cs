using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour
{
    public Unit dino1;
    public Unit dino2;
    public Unit dino3;

    public int maxTeamHealth;
    public int currentTeamHealth;
    public int specPoints;

    public bool DealDamage(int dino, int dmg)
    {

        if (dino == 1)
        {
            return dino1.Damage(dmg);
        }
        else if (dino == 2)
        {
            return dino2.Damage(dmg);
        }
        else if (dino == 3)
        {
            return dino3.Damage(dmg);
        }
        return false;
    }
}
