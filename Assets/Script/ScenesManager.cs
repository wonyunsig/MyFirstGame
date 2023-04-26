using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public void SceneLoad(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    public void SceneLoad(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
