using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{

    public int health = 5000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void damagePlayer(int damage)
    {
        health -= damage;
        Debug.Log("Health: " + health);
        if(health < 1)
        {
            //call gameover 
            Debug.Log("Game Over");
        }    
    }
}
