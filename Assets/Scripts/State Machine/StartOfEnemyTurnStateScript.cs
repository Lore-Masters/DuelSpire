using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class StartOfEnemyTurnStateScript : MonoBehaviour
{
    private void Awake()
    {
        Signals.Get<StartOfEnemyTurnSignal>().AddListener(OnEnter);
    }

    private void OnEnter()
    {
        StateMachine.SetState(State.StartOfEnemyTurnState);
        Signals.Get<EnemyTurnSignal>().Dispatch();
    }
}
