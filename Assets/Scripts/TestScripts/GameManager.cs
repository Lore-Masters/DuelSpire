using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    NoraState currentState;

    public PlayerTurnState playerTurnState = new PlayerTurnState();
    public EnemyTurnState enemyTurnState = new EnemyTurnState();
    

    // Start is called before the first frame update
    void Start()
    {
        ChangeState((int)StateType.PlayerTurn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //called when changing state, exits current state and enters new state
    public void ChangeState(int newState)
    {
        if(currentState != null)
            currentState.OnExit();
        
        currentState = StateLookup((StateType)newState);
        currentState.OnStateEnter(this);
    }

    private NoraState StateLookup(StateType newState)
    {
        switch (newState)
        {
            case StateType.PlayerTurn: 
                return playerTurnState;
            case StateType.EnemyTurn:
                return enemyTurnState;
        }
        return null;
    } 
}
