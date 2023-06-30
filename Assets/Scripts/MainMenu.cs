using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEditor;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
            // EditorApplication.isPlaying = false; // for playing mode in editor
        #endif
        
        Application.Quit(); // for quiting on the built version
    }
}
