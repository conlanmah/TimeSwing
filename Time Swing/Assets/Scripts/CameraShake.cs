using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float ShakeMultiplier;
    public IEnumerator Shake (float duration, float magnitude)
    {
        Vector3 OriginalPos = transform.localPosition;
        float elapsedTime = 0.0f;

        while(duration > elapsedTime)
        {
            float hd = duration/2;
            float x = (Random.Range(-1,1) * magnitude * ((-Mathf.Abs(elapsedTime-hd)+hd)/hd))* ShakeMultiplier;
            float y = (Random.Range(-1,1) * magnitude * ((-Mathf.Abs(elapsedTime-hd)+hd)/hd)) * ShakeMultiplier;
            transform.localPosition= new Vector3(x, y, OriginalPos.z);
            elapsedTime += Time.deltaTime;
            yield return null;

        }

        transform.localPosition = OriginalPos;
    }
}
