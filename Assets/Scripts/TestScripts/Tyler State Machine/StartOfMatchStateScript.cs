using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class StartOfMatchStateScript : MonoBehaviour
{
	private void Start()
	{
        Signals.Get<StartOfMatchSignal>().AddListener(OnEnter);
	}

    private void OnEnter()
    {
        Signals.Get<PlayerSetupSignal>().Dispatch();
    }
}
