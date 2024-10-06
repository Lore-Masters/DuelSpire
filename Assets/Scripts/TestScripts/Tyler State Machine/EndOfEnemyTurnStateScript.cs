using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class EndOfenemyTurnStateScript : MonoBehaviour
{
    private void Awake()
    {
        Signals.Get<EndOfEnemyTurnSignal>().AddListener(OnEnter);
    }

	private void OnEnter()
	{
        StateMachine.SetState(State.EndOfEnemyTurnState);
        Signals.Get<StartOfPlayerTurnSignal>().Dispatch();
	}
}
