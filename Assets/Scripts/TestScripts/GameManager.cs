using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    NoraState currentState;

    public PlayerTurnState playerTurnState = new PlayerTurnState();
    

    // Start is called before the first frame update
    void Start()
    {
        ChangeState(playerTurnState);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeState(NoraState newState)
    {
        if(currentState != null)
            currentState.OnExit();
        
        currentState = newState;
        currentState.OnStateEnter(this);
    }
}
