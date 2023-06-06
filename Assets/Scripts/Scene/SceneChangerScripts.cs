using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChangerScripts : MonoBehaviour
{
    
   

    public void ChangeSceneByName(string sceneName)
    {

        SceneManager.LoadScene(sceneName);
    }

    public void NextScene()
    {
        
        if (SceneManager.GetActiveScene().buildIndex != SceneManager.sceneCount)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
            Debug.Log("It was last scene");
        }
    }
    public void PreviousScene()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        else
        {
            Debug.Log("It was first scene");
            SceneManager.LoadScene(SceneManager.sceneCount - 1);
        }
        
    }
}
