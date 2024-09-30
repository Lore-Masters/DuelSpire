using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class StartOfEnemyTurnStateScript : MonoBehaviour
{
    private void Start()
    {
        Signals.Get<StartOfEnemyTurnSignal>().AddListener(OnEnter);
    }

    private void OnEnter()
    {
        Signals.Get<EnemyTurnSignal>().Dispatch();
    }
}
