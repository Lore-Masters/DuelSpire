using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurnState : NoraState
{
    protected override void OnEnter()
    {
        Debug.Log("Starting Enemy Turn");
    }

    public override void OnUpdate()
    {
        //gm.gameObject.GetComponent<PlayerInfo>().damagePlayer(1000);
    }

    public override void OnExit()
    {
        Debug.Log("Ending Enemy Turn");
    }
}
