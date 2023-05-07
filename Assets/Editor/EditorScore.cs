using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PlayerPrefInit))]
public class EditorScore : Editor
{

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        PlayerPrefInit script = (PlayerPrefInit)target;

        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Force Initialize"))
        {
            script.ForceInit();
        }

        if (GUILayout.Button("Reset All"))
        {
            script.ResetAllValues();
        }

        GUILayout.EndHorizontal();
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Reset String"))
        {
            script.ResetStringValues();
        }

        if (GUILayout.Button("Reset Float"))
        {
            script.ResetFloatValues();
        }

        GUILayout.EndHorizontal();
    }

}
