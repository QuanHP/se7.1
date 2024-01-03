using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

[InitializeOnLoad]
public class AutoSaveOnExitPlayMode
{
    static AutoSaveOnExitPlayMode()
    {
        EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
    }

    private static void OnPlayModeStateChanged(PlayModeStateChange state)
    {
        if (state == PlayModeStateChange.ExitingPlayMode)
        {
            Debug.Log("Exiting Play mode. Saving scenes...");

            // Lưu tất cả các Scene mở trong Editor
            for (int i = 0; i < SceneManager.sceneCount; i++)
            {
                Scene scene = SceneManager.GetSceneAt(i);
                if (scene.isDirty)
                {
                    EditorSceneManager.SaveScene(scene);
                }
            }

            AssetDatabase.SaveAssets();

            Debug.Log("Scenes saved!");
        }
    }
}
