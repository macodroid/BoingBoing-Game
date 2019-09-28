using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isGrounded = false;    
    public float playerSpeed = 5f;
    public float jumpHeight = 5f;
    public float speedOfAcceleration = 3f;

     
    private float directionX;
    private Rigidbody2D rb2d;


    // Start is called before the first frame update
    void Start()
    {
        
    }




    // Update is called once per frame
    private void FixedUpdate()
    {
        

        Vector3 movement = new Vector3(Input.acceleration.x * speedOfAcceleration, 0f, 0f);
        transform.position += movement * Time.deltaTime * playerSpeed;
        Invoke("Jump", 1f);

    }

    private void Jump()
    {
        if (isGrounded)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
            isGrounded = false;
        }
      
    }
    
}
