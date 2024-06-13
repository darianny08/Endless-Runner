using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object left along its x axis 1 unit/secong.
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        if (transform.position.x < -16) 
        {
            Destroy(gameObject);
        }

    }
}
