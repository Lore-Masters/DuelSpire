using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public class PlayerHealthChanged : ASignal<int> { }


public class PlayerInfo : MonoBehaviour
{
    public int health = 5000;

    // Start is called before the first frame update
    void Start()
    {
        Signals.Get<PlayerHealthChanged>().AddListener(damagePlayer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void damagePlayer(int amount)
    {
        health += amount;
        Debug.Log("Health: " + health);
        if(health < 1)
        {
            //call gameover 
            Debug.Log("Game Over");
        }    
    }
}
