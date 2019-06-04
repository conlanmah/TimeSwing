using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    public GameObject Hook;
    public float LaunchForce;

    private Rigidbody2D rb;
    private TimeSlow TimeSlow;
    private Vector2 OrginTouch;
    private Vector2 BetweenVector;
    private bool Launch;
    private LineRenderer lr;
    private Rigidbody2D Hookrb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        TimeSlow = gameObject.GetComponent<TimeSlow>();
        lr = gameObject.GetComponent<LineRenderer>();
        Hookrb = Hook.GetComponent<Rigidbody2D>();

        Hook.SetActive(false);
        lr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        TouchSensing();
        if(lr.enabled)
        {
            lr.SetPosition(0, transform.position);
            lr.SetPosition(1, Hook.transform.position);
        }
    }

    private void FixedUpdate()
    {
        if(Launch)
        {
            //rb.AddForce(BetweenVector*LaunchForce, ForceMode2D.Impulse);
        }
        Launch = false;

        Mathf.Clamp(transform.position.y, -10, 10);
    }


    private void TouchSensing()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch(touch.phase)
            {
                case TouchPhase.Began:
                    OrginTouch = Camera.main.ScreenToWorldPoint(touch.position);
                    Destroy(Hook.GetComponent<FixedJoint2D>());
                    break;
                
                case TouchPhase.Ended:
                    TimeSlow.SetTimeTo(1);
                    Launch = true;
                    Hook.SetActive(true);
                    lr.enabled = true;
                    Hook.transform.position = transform.position;
                    Hookrb.AddForce(BetweenVector*LaunchForce, ForceMode2D.Impulse);
                    Destroy(Hook.GetComponent<FixedJoint2D>());
                    break;

                case TouchPhase.Moved:
                    Vector2 NewTouch = Camera.main.ScreenToWorldPoint(touch.position);
                    BetweenVector = NewTouch - OrginTouch;
                    BetweenVector = BetweenVector.normalized;
                    float dir = Mathf.Acos(BetweenVector.x/1) * Mathf.Rad2Deg;
                    if (BetweenVector.y < 0)
                    {
                        dir = -dir;
                    }
                    rb.rotation = dir;
                    break;
            }
            
        }
    }
}
