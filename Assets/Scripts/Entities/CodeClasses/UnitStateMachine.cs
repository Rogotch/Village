using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UnitStateMachine : MonoBehaviour
{
    protected UnitState _UnitState;

    public void SetState(UnitState _state)
    {
        _UnitState = _state;
        StartCoroutine(_UnitState.Start());
    }
}
