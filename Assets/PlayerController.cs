using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRb;
    [SerializeField] float jumpForce;
    bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            playerRb.AddForce(new Vector2(0,1) * jumpForce , ForceMode2D.Impulse);
            canJump = false;
            Debug.Log ("space bar was pressed");
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Platform") 
        {
            canJump = true;
        }
    }
}
