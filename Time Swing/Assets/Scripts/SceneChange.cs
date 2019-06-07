using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public Animator ani;
    private string scene;
    public void ChangeSceneTo(string scenename)
    {
        ani.SetTrigger("End");
        scene = scenename;
        Invoke("LoadScene", 1);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(scene);
    }
}
