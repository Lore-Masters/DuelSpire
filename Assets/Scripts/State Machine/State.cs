using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class State : MonoBehaviour
{
    [Tooltip("Next state in the machine")]
    [SerializeField]
    public List<Transition> transitions;
}

[System.Serializable]
public class Transition
{
    [Tooltip("Signals to wait on")]
    [SerializeField]
    public List<ASignal> signals;

    [Tooltip("State to switch to")]
    [SerializeField]
    public State nextState;
}
