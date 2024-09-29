using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NoraState
{
    //gives us a way to interact with other scripts and game objects in the scene
    protected GameManager gm;

    //runs everytime entering the new state
    public void OnStateEnter(GameManager gameManager)
    {
        gm = gameManager; //if we wanted to do this at creation we would need to make a constructor in each class (sure there are other solutions, this is justa problem I ran into)
        OnEnter();
    }

    //runs when entering the new state, override in subclasses
    protected virtual void OnEnter()
    {
        
    }

    //runs at every update from gm, override in subclasses
    public virtual void OnUpdate()
    {

    }

    //runs when exiting the current state, override in subclasses
    public virtual void OnExit()
    {

    }
}
