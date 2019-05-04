using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildInGameCommands : MonoBehaviour
{
    [Tooltip("GetKey reference to Reload Current Scene while in Unity's Play Mode")]
    public string ReloadScene = "f1";

    [Tooltip("GetKey reference to quit while in Build Play Mode")]
    public string QuitBuild = "escape";

    void Update()
    {
        ReloadSceneCurrentScene();
        QuitApplicationBuild();
    }

    /* |-_-| In-Game Functions */
    // Reload current scene
    void ReloadSceneCurrentScene()
    {
        if (Input.GetKey(ReloadScene))
        {
            Scene loadedLevel = SceneManager.GetActiveScene();
            SceneManager.LoadScene(loadedLevel.buildIndex);
        }
    }

    // Quit game
    void QuitApplicationBuild()
    {
        if (Input.GetKey(QuitBuild))
        {
            Application.Quit();
        }
    }

}