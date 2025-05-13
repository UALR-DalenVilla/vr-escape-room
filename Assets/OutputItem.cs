using UnityEngine;

public class OutputItem : MonoBehaviour
{
    [Tooltip("Optional description of what this output does (e.g., opens a door, reveals clue).")]
    public string outputDescription;

    public void TriggerOutput()
    {
        Debug.Log($"{name} output triggered!");

        // TODO: Add actual logic like opening doors, playing animations, etc.
        // Example: animator.SetTrigger("Open");
    }
}
