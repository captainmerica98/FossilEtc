using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { START, TURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    public GameObject playerTeam;
    public GameObject enemyTeam;

    public Transform playerBattleStation;
    public Transform enemyBattleStation;

    public BattleState state;

    Team playerUnit;
    Team enemyUnit;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    void SetupBattle()
    {
        GameObject playerGo = Instantiate(playerTeam, playerBattleStation);
        playerUnit = playerGo.GetComponent<Team>();

        GameObject enemyGo = Instantiate(enemyTeam, enemyBattleStation);
        enemyUnit = enemyGo.GetComponent<Team>();
    }

 
}
