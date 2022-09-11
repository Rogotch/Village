using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UnitState : MonoBehaviour
{
    public virtual IEnumerator Start() 
    {
        yield break;
    }
    public virtual IEnumerator Mining() 
    {
        yield break;
    }
    public virtual IEnumerator Idle() 
    {
        yield break;
    }
    public virtual IEnumerator Move() 
    {
        yield break;
    }
    public virtual IEnumerator Attack() 
    {
        yield break;
    }

    
}
