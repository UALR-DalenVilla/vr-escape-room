using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class PuzzleObject : MonoBehaviour
{
    public string puzzleID;
    public UnityEvent onSolve;
    public bool isSolved;

    public virtual void Interact() { }
    public virtual void Solve()
    {
        isSolved = true;
        onSolve?.Invoke();
    }
}
