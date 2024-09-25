using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class StartOfMatch_To_PlayerSetup : MonoBehaviour
{
    private StartOfMatch_To_PlayerSetupSignal signal;

    public StartOfMatch_To_PlayerSetupSignal Get()
    {
        return signal;
    }

    public class StartOfMatch_To_PlayerSetupSignal : ASignal { }
}
