using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHookStick : MonoBehaviour
{
    public bool stuck;
    public GameObject StuckObject;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D Collision)
    {
        if(Collision.gameObject.CompareTag("Block"))
        {
            StuckObject = Collision.gameObject;
            FixedJoint2D joint = gameObject.AddComponent<FixedJoint2D>();   
            joint.connectedBody = Collision.gameObject.GetComponent<Rigidbody2D>(); 
            joint.enableCollision = false; 
            stuck = true;
        }
        
    }
}
