using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class BasicSpellEffect : ICardEffect
{
    public void activateEffect()
    {
        Signals.Get<PlayerHealthChanged>().Dispatch(200);
    }
}
