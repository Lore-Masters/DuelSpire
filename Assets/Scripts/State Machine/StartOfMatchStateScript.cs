using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class StartOfMatchStateScript : MonoBehaviour
{
	private void Awake()
	{
        Signals.Get<StartOfMatchSignal>().AddListener(OnEnter);
	}

    private void OnEnter()
    {
        StateMachine.SetState(State.StartOfMatchState);
        Signals.Get<PlayerSetupSignal>().Dispatch();
    }
}
