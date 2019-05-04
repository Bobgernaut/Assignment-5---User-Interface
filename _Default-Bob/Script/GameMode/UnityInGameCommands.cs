using UnityEngine;
using UnityEditor;

public class UnityInGameCommands : MonoBehaviour
{
    [Tooltip("GetKey reference to quit while in Unity's Play Mode")]
    public string QuitPlay = "f4";

#if (UNITY_EDITOR)

    void Update()
    {
        StopGame();
    }

    /* |-_-| In-Game Functions */
    // Stop game while running in Unity Application

    void StopGame()
    {
        if (Input.GetKey(QuitPlay))
        {
            EditorApplication.isPlaying = false;
        }
    }
#endif
}