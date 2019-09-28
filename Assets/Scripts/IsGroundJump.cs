using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGroundJump : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision2d)
    {
        if (collision2d.collider.tag == "Ground")
        {
            player.GetComponent<PlayerController>().isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision2d)
    {
        if (collision2d.collider.tag == "Ground")
        {
            player.GetComponent<PlayerController>().isGrounded = false;
        }
    }

}
