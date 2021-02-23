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

    Team player;
    Team enemy;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    void SetupBattle()
    {
        GameObject playerGo = Instantiate(playerTeam, playerBattleStation);
        player = playerGo.GetComponent<Team>();

        GameObject enemyGo = Instantiate(enemyTeam, enemyBattleStation);
        enemy = enemyGo.GetComponent<Team>();
    }

    IEnumerator PlayerAttack()
    {
        enemy.DealDamage(1,10);

        yield return new WaitForSeconds(2f);
    }

    public void OnAttackButton()
    {
        if (state != BattleState.TURN)
            return;

        StartCoroutine(PlayerAttack());

    }
 
}
