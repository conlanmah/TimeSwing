using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeOnEnabled : MonoBehaviour
{
    private CameraShake CamShake;
    void Awake()
    {
        CamShake = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraShake>();
    }

    void OnEnable()
    {
        StartCoroutine(CamShake.Shake(.2f,.2f));
    }

}
