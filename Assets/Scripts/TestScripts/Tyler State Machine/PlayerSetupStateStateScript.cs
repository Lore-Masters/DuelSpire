using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class PlayerSetupStateScript : MonoBehaviour
{
    private void Start()
    {
        Signals.Get<PlayerSetupSignal>().AddListener(OnEnter);
    }

    private void OnEnter()
	{
        Signals.Get<MonsterSetupSignal>().Dispatch();
	}
}
