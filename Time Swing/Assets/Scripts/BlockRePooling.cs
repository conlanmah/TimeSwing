using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRePooling : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if(Other.CompareTag("BlockRePool"))
        {
            transform.position = new Vector2(transform.position.x, 11f);
        }
    }
}
