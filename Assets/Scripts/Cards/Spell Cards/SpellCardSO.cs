using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Our Assets/New Spell Card")]

public class SpellCardSO : GenericCardSO
{
    [Tooltip("The area where the spell is played")]
    [SerializeField]
    public TargetingType targetType;
}
