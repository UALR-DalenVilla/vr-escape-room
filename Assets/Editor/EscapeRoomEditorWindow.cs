// Editor/EscapeRoomEditorWindow.cs
using UnityEditor;
using UnityEngine;

public class EscapeRoomEditorWindow : EditorWindow
{
    private GameObject selectedObject;

    [MenuItem("Window/Escape Room Editor")]
    public static void ShowWindow()
    {
        GetWindow<EscapeRoomEditorWindow>("Escape Room Editor");
    }

    private void OnGUI()
    {
        GUILayout.Label("Escape Room Puzzle Setup", EditorStyles.boldLabel);
        EditorGUILayout.Space();

        // -- Colored Label --
        GUIStyle coloredLabel = new GUIStyle(EditorStyles.label);
        coloredLabel.richText = true;
        EditorGUILayout.LabelField("<color=orange><b>Target Object</b></color>", coloredLabel);

        // -- Object Field (no label) --
        selectedObject = (GameObject)EditorGUILayout.ObjectField(selectedObject, typeof(GameObject), true);

        // -- Early exit if nothing is selected --
        if (selectedObject == null)
        {
            EditorGUILayout.HelpBox("Please select a GameObject with an InputItem or OutputItem script attached.", MessageType.Info);
            return;
        }

        // -- Show InputItem section if applicable --
        if (selectedObject.TryGetComponent(out InputItem input))
        {
            EditorGUILayout.Space();
            GUI.backgroundColor = Color.cyan;
            GUILayout.BeginVertical("box");
            GUI.backgroundColor = Color.white;

            GUILayout.Label("Input Item Settings", EditorStyles.boldLabel);

            //// Output list UI
            //for (int i = 0; i < input.outputs.Count; i++)
            //{
            //    input.outputs[i] = (OutputItem)EditorGUILayout.ObjectField($"Output {i + 1}", input.outputs[i], typeof(OutputItem), true);
            //}

            if (GUILayout.Button("Add Output"))
            {
                //input.outputs.Add(null);
            }

            GUILayout.EndVertical();
        }
        else
        {
            EditorGUILayout.HelpBox("Selected object does not contain an InputItem script.", MessageType.Warning);
        }
    }
}
