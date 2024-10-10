using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericCardSO : ScriptableObject
{
    [Tooltip("The name of the card")]
	[SerializeField]
	public string nameOfCard;

	[Tooltip("The image the card has")]
	[SerializeField]
	public Sprite cardImage;

    [Tooltip("The basic effect of the monster")]
    [SerializeReference]
    public ICardEffect basicEffect;

    [Tooltip("The special effect of the monster")]
	[SerializeReference]
    public ICardEffect specialEffect;

	[Tooltip("The special effect of the monster")]
	[SerializeField]
    public string flavorText;


	public void activateBasicEffect()
	{
		basicEffect?.activateEffect();
	}

	public void activateSpecialEffect()
	{
		specialEffect?.activateEffect();
	}

}
