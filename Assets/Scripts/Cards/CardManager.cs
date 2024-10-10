using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField]
    public GenericCardSO cardSO;

    [SerializeField]
    private Image cardArt;

    // Start is called before the first frame update
    void Start()
    {
        cardArt.sprite = cardSO.cardImage;
        GetComponentInChildren<ParticleSystem>().Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition != new Vector3(0,0,0) && Input.GetMouseButtonUp(0))
        {
            cardSO.activateBasicEffect();
            Destroy(this.gameObject);
        }
    }
}
