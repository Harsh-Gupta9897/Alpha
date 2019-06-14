using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{
    
    public void MainScreen()
    {
        SceneManager.LoadScene("MainScreen");
    }
    public void ExitScreen()
    {
        Application.Quit();
        Debug.Log("Exit App");
    }
}
