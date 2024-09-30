using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Our Assets/New Monster Card")]

public class MonsterCardSO : GenericCardSO
{
	[Tooltip("The types the card is a part of")]
	[SerializeField]
	public List<MonsterTypes> types;

	[Tooltip("The health of the card")]
	[SerializeField]
	public int health;

	[Tooltip("The amount of damage the card does")]
	[SerializeField]
	public int attack;

	[Tooltip("The current statuses the monster has")]
	[SerializeField]
	public List<StatusEffect> currentStatuses;

}
