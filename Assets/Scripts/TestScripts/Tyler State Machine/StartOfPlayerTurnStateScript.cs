using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class StartOfPlayerTurnStateScript : MonoBehaviour
{
    private State thisState;

    private void Awake()
    {
        thisState = State.StartOfPlayerTurnState;
        Signals.Get<StartOfPlayerTurnSignal>().AddListener(OnEnter);
    }

    private void OnEnter()
    {
        StateMachine.SetState(thisState);
    }

    public void EndPlayerTurn()
    {
        if (StateMachine.GetState() == thisState)
            Signals.Get<EndOfPlayerTurnSignal>().Dispatch();
    }
}
