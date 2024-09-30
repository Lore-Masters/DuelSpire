using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class EndOfenemyTurnStateScript : MonoBehaviour
{
    private void Start()
    {
        Signals.Get<EndOfEnemyTurnSignal>().AddListener(OnEnter);
    }

	private void OnEnter()
	{
        Signals.Get<StartOfMatchSignal>().Dispatch();
	}
}
