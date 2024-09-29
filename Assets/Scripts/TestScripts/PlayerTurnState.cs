using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurnState : NoraState
{

    protected override void OnEnter()
    {
        //draw new hand (could be in OnExit())
        //enable end of turn button
        //enable play cards
        //tick down effects
        Debug.Log("Entering New Player Turn");
    }

    public override void OnUpdate()
    {
        
    }

    public override void OnExit()
    {
        //disable end of turn button
        //discard hand
        Debug.Log("Exiting Player Turn");
    }
}

