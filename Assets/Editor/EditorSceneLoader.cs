using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public class EditorSceneLoader : EditorWindow
{
    public string[] SceneList = { "MainArcade", "", "", "", "" };

    [MenuItem("Window/Scene Loader")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<EditorSceneLoader>("Scene Loader");
    }

    

    private void OnGUI()
    {
        GUILayout.Label("Editor window for the purpose of loading scenes.");

        if (GUILayout.Button("Return to the Arcade"))
        {
            if (Application.isPlaying)
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("MainArcade");
            }
            else
            {
                EditorSceneManager.OpenScene("Assets/Scenes/MainArcade.unity");
            }
            
        }

        if (GUILayout.Button("Go to Flappy Game"))
        {
            if (Application.isPlaying)
            {
                SceneManager.LoadScene("Flappy Bird");

            }
            else
            {
                EditorSceneManager.OpenScene("Assets/Scenes/Flappy Bird.unity");
            }

            
        }

        if (GUILayout.Button("Go to Bullet Hell Game"))
        {
            if (Application.isPlaying)
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("BulletHell");
            }
            else
            {
                EditorSceneManager.OpenScene("Assets/Scenes/BulletHell.unity");
            }

            
        }

        if (GUILayout.Button("Go to Tomb Ascent Game"))
        {
            if (Application.isPlaying)
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("TombAscent");
            }
            else
            {
                EditorSceneManager.OpenScene("Assets/Scenes/TombAscent.unity");
            }

            
        }

        if (GUILayout.Button("Go to Asteroid Game"))
        {

            if (Application.isPlaying)
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("Asteroid");
            }
            else
            {
                EditorSceneManager.OpenScene("Assets/Scenes/Asteroid.unity");
            }
        }

        /*
        ScriptableObject target = this;
        SerializedObject so = new SerializedObject(target);
        SerializedProperty stringsProperty = so.FindProperty("SceneList");
        EditorGUILayout.PropertyField(stringsProperty, true); // True means show children
        so.ApplyModifiedProperties();
        */
    }
}
