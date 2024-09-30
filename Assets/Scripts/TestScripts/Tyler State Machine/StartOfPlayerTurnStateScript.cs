using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class StartOfPlayerTurnStateScript : MonoBehaviour
{
    private void Start()
    {
        Signals.Get<StartOfPlayerTurnSignal>().AddListener(OnEnter);
    }

    private void OnEnter()
    {
        Signals.Get<EndOfPlayerTurnSignal>().Dispatch();
    }
}
