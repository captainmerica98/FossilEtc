using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour
{
    public Unit dino1;
    public Unit dino2;
    public Unit dino3;

    List<Unit> dinos;

    public int maxTeamHealth;
    public int currentTeamHealth;
    public int specPoints;

    public void InitializeTeam()
    {
        dino1.attack = 1;
        dinos.Add(Instantiate(dino1));
        dinos.Add(Instantiate(dino2));
        dinos.Add(Instantiate(dino3));
    }

    public bool DealDamage(int dino, int dmg)
    {
        return dinos[dino-1].Damage(dmg);
    }
}
