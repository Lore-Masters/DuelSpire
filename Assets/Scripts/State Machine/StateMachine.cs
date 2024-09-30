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
	public State currentState;

	private void Start()
	{
		Signals.Get<StartOfMatchSignal>().AddListener(SetStartOfMatch);
		Signals.Get<PlayerSetupSignal>().AddListener(SetPlayerSetup);
		Signals.Get<MonsterSetupSignal>().AddListener(SetMonsterSetup);
		Signals.Get<StartOfPlayerTurnSignal>().AddListener(SetStartOfPlayerTurn);
		Signals.Get<EndOfPlayerTurnSignal>().AddListener(SetEndOfPlayerTurn);
		Signals.Get<StartOfEnemyTurnSignal>().AddListener(SetStartOfEnemyTurn);
        Signals.Get<EndOfEnemyTurnSignal>().AddListener(SetEndOfEnemyTurn);
		Signals.Get<EndOfCombatSignal>().AddListener(SetEndOfCombat);
	}

    public void test()
    {
        Signals.Get<StartOfMatchSignal>().Dispatch();
    }

	private void SetStartOfMatch()
	{
		currentState = State.StartOfMatchState;
	}

	private void SetPlayerSetup()
	{
		currentState = State.PlayerSetupState;
	}

	private void SetMonsterSetup()
	{
		currentState = State.MonsterSetupState;
	}

	private void SetStartOfPlayerTurn()
	{
		currentState = State.StartOfPlayerTurnState;
	}

	private void SetEndOfPlayerTurn()
	{
		currentState = State.EndOfPlayerTurnState;
	}

	private void SetStartOfEnemyTurn()
	{
		currentState = State.StartOfEnemyTurnState;
	}

    private void SetEndOfEnemyTurn()
	{
		currentState = State.EndOfEnemyTurnState;
	}

	private void SetEndOfCombat()
	{
		currentState = State.EndOfCombatState;
	}
}
