using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class EndOfPlayerTurnStateScript : MonoBehaviour
{
    private void Start()
    {
        Signals.Get<EndOfPlayerTurnSignal>().AddListener(OnEnter);
    }

	private void OnEnter()
	{
        Signals.Get<StartOfEnemyTurnSignal>().Dispatch();
	}
}
