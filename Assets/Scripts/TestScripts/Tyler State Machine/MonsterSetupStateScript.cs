using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class MonsterSetupStateScript : MonoBehaviour
{
    private void Start()
    {
        Signals.Get<MonsterSetupSignal>().AddListener(OnEnter);
    }

    private void OnEnter()
    {
        Signals.Get<StartOfPlayerTurnSignal>().Dispatch();
    }
}
