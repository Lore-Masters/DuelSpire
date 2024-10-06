using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class MonsterSetupStateScript : MonoBehaviour
{
    private void Awake()
    {
        Signals.Get<MonsterSetupSignal>().AddListener(OnEnter);
    }

    private void OnEnter()
    {
        StateMachine.SetState(State.MonsterSetupState);
        Signals.Get<StartOfPlayerTurnSignal>().Dispatch();
    }
}
