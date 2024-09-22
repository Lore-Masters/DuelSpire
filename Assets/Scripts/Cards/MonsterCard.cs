using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Our Assets/New Monster Card")]

public class MonsterCard : ScriptableObject
{
        [Tooltip("The name of the card")]
        [SerializeField]
        protected string name;

        [Tooltip("The types the card is a part of")]
        [SerializeField]
        public List<MonsterTypes> types;

        [Tooltip("The effect the monster has")]
        [SerializeField]
        protected Sprite monsterImage;

    [Tooltip("The health of the card")]
        [SerializeField]
        public int health;

        [Tooltip("The amount of damage the card does")]
        [SerializeField]
        public int attack;

        [Tooltip("The target the card will prioritise")]
        [SerializeField]
        public TargetPriority targetPriority;

        [Tooltip("The basic effect of the monster")]
        [SerializeField]
        protected CardEffect baseEffect;

        [Tooltip("The special effect of the monster")]
        [SerializeField]
        protected CardEffect specialEffect;

        [Tooltip("The special effect of the monster")]
        [SerializeField]
        protected string flavorText;

        [Tooltip("The current statuses the monster has")]
        [SerializeField]
        public List<StatusEffect> currentStatuses;
}
