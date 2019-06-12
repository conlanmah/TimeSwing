using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRePooling : MonoBehaviour
{

    public float timeScaledtoScale;

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
            timeScaledtoScale = ((-0.06f * Time.timeSinceLevelLoad)+5)/10;
            float random = Mathf.Clamp(Random.Range(timeScaledtoScale-.2f, timeScaledtoScale+.2f), 0.1f, .5f);
            transform.localScale = Vector3.one * random;
        }
    }
}
