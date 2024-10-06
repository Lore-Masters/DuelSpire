using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;
using System;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    private List<MonsterCardSO> enemies;

    [SerializeField]
    private PlayerInfo player;

    // Start is called before the first frame update
    void Start()
    {
        Signals.Get<EnemyTurnSignal>().AddListener(StartEnemyAttacks);
    }

    private void StartEnemyAttacks()
    {
        foreach (var enemy in enemies)
        {
            //TODO: Should want to have this be a method to call in the enemy script... probably
            enemy.activateBasicEffect();
            //Debug.Log("Health: " + player.health);
        }

        EndEnemyAttacks();
    }

    private void EndEnemyAttacks()
    {
        Signals.Get<EndOfEnemyTurnSignal>().Dispatch();
    }
}
