using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class EndOfPlayerTurnStateScript : MonoBehaviour
{
    private void Awake()
    {
        Signals.Get<EndOfPlayerTurnSignal>().AddListener(OnEnter);
    }

	private void OnEnter()
	{
        StateMachine.SetState(State.EndOfPlayerTurnState);
        Signals.Get<StartOfEnemyTurnSignal>().Dispatch();
	}
}
