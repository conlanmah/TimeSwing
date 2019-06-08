using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSlow : MonoBehaviour
{

    public bool ChangeTime;

    private float time;
    public float DefaultTime;
    public float ChangeSpd;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("StartTimeChange",1);
    }

    // Update is called once per frame
    void Update()
    {

        Time.timeScale = time;
        Time.fixedDeltaTime = Time.timeScale * .02f;

        if(ChangeTime)
        {
            if(time < DefaultTime)
            {
                time += ChangeSpd;
            }
            else if (time > DefaultTime)
            {
                time -= ChangeSpd;
            }
            
            time = Mathf.Clamp(time, 0.01f , 1);
        }
        else
        {
            time = 1;
        }
 
    }

    public void SetTimeTo(float _time)
    {
        if(ChangeTime)
        {
            time = _time;
        }
        
    }

    private void StartTimeChange()
    {
        ChangeTime = true;
    }
}
