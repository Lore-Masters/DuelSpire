using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class PlayerSetupStateScript : MonoBehaviour
{
    private void Awake()
    {
        Signals.Get<PlayerSetupSignal>().AddListener(OnEnter);
    }

    private void OnEnter()
	{
        StateMachine.SetState(State.PlayerSetupState);
        Signals.Get<MonsterSetupSignal>().Dispatch();
	}
}
