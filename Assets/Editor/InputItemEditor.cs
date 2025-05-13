// Editor/InputItemEditor.cs
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(InputItem))]
public class InputItemEditor : Editor
{
    private bool showAdvancedInspector = false;

    public override void OnInspectorGUI()
    {
        // Button to switch modes
        showAdvancedInspector = GUILayout.Toggle(showAdvancedInspector, showAdvancedInspector ? "Escape Room Editor Mode" : "Default Inspector Mode", "Button");

        EditorGUILayout.Space();

        if (showAdvancedInspector)
        {
            DrawEscapeRoomEditor();
        }
        else
        {
            DrawDefaultInspector();
        }
    }

    private void DrawEscapeRoomEditor()
    {
        InputItem inputItem = (InputItem)target;

        GUI.backgroundColor = Color.cyan;
        GUILayout.BeginVertical("box");
        GUILayout.Label("Escape Room Puzzle Setup", EditorStyles.boldLabel);
        GUI.backgroundColor = Color.white;

        if (GUILayout.Button("Add Output"))
        {
            //inputItem.outputs.Add(null);
        }

        //for (int i = 0; i < inputItem.outputs.Count; i++)
        //{
        //    inputItem.outputs[i] = (OutputItem)EditorGUILayout.ObjectField($"Output {i + 1}", inputItem.outputs[i], typeof(OutputItem), true);
        //}

        GUILayout.EndVertical();

        if (GUI.changed)
        {
            EditorUtility.SetDirty(inputItem);
        }
    }
}
