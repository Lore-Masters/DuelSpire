using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using deVoid.Utils;

public enum State
{
	StartOfMatchState,
	PlayerSetupState,
	MonsterSetupState,
	StartOfPlayerTurnState,
	EndOfPlayerTurnState,
	StartOfEnemyTurnState,
    EndOfEnemyTurnState,
	EndOfCombatState
};

public class StartOfMatchSignal : ASignal { }
public class PlayerSetupSignal : ASignal { }
public class MonsterSetupSignal : ASignal { }
public class StartOfPlayerTurnSignal : ASignal { }
public class EndOfPlayerTurnSignal : ASignal { }
public class StartOfEnemyTurnSignal : ASignal { }
public class EnemyTurnSignal : ASignal { }
public class EndOfEnemyTurnSignal : ASignal { }
public class EndOfCombatSignal : ASignal { }

public class StateMachine : MonoBehaviour
{
	public static State currentState;

	private void Start()
	{
        //TODO: Get rid of this
        /*Signals.Get<StartOfMatchSignal>().AddListener(SetStartOfMatch);
		Signals.Get<PlayerSetupSignal>().AddListener(SetPlayerSetup);
		Signals.Get<MonsterSetupSignal>().AddListener(SetMonsterSetup);
		Signals.Get<StartOfPlayerTurnSignal>().AddListener(SetStartOfPlayerTurn);
		Signals.Get<EndOfPlayerTurnSignal>().AddListener(SetEndOfPlayerTurn);
		Signals.Get<StartOfEnemyTurnSignal>().AddListener(SetStartOfEnemyTurn);
        Signals.Get<EndOfEnemyTurnSignal>().AddListener(SetEndOfEnemyTurn);
		Signals.Get<EndOfCombatSignal>().AddListener(SetEndOfCombat);*/

        Signals.Get<StartOfMatchSignal>().Dispatch();
	}

    private void Update()
    {
        //Debug.Log(currentState);
    }

    public static State GetState()
    {
        return currentState;
    }

    public static void SetState(State newState)
    {
        currentState = newState;
    }
}
