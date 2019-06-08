using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
public SceneChange SceneChange;

public TimeSlow Time;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Lava"))
        {
            SceneChange.ChangeSceneTo("Menu");
            Time.ChangeTime = false;
        }
    }
}
