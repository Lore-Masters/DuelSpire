using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class CardManager : MonoBehaviour
{
    [SerializeField]
    public GenericCardSO cardSO;

    [SerializeField]
    private Image cardArt;

    [SerializeField]
    private TextMeshProUGUI cardName;

    [SerializeField]
    private TextMeshProUGUI cardDescription;

    [SerializeField]
    private TextMeshProUGUI cardFlavor;

    // Start is called before the first frame update
    void Start()
    {
        cardArt.sprite = cardSO.cardImage;
        cardName.text = cardSO.nameOfCard;
        //cardDescription.text = cardSO.nameOfCard;
        cardFlavor.text = cardSO.flavorText;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition != new Vector3(0,0,0) && Input.GetMouseButtonUp(0))
        {
            cardSO.activateBasicEffect();
            //Destroy(this.gameObject);
        }
    }
}
