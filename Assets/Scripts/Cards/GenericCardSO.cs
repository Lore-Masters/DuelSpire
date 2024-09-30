using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericCardSO : ScriptableObject
{
	[Tooltip("The name of the card")]
	[SerializeField]
	protected string nameOfCard;

	[Tooltip("The image the card has")]
	[SerializeField]
	protected Sprite cardImage;

	[Tooltip("The target the card will prioritise")]
	[SerializeField]
	public TargetPriority targetPriority;

	[Tooltip("The basic effect of the monster")]
	[SerializeReference]
	protected ICardEffect basicEffect;

	[Tooltip("The special effect of the monster")]
	[SerializeReference]
	protected ICardEffect specialEffect;

	[Tooltip("The special effect of the monster")]
	[SerializeField]
	protected string flavorText;


	public void activateBasicEffect()
	{
		basicEffect?.activateEffect();
	}

	public void activateSpecialEffect()
	{
		specialEffect?.activateEffect();
	}

}
