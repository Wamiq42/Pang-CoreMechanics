using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    //private float speed = 5.0f;
    public float bounceSpeed = 800.0f;
    public float boundryBounceSpeed = 400.0f;
    public Rigidbody ballRigidbody;
  
   

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.x < -5.0f)
        //    ballRigidbody.AddForce(Vector3.right * speed, ForceMode.Acceleration);
        //if (transform.position.x > 5.0f)
        //    ballRigidbody.AddForce(Vector3.right * -speed, ForceMode.Acceleration);

                    
    }

    void MoveFire()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
            ballRigidbody.AddForce(Vector3.up *bounceSpeed, ForceMode.Force);
        else if(collision.gameObject.CompareTag("LeftBoundary"))
            ballRigidbody.AddForce(Vector3.right * boundryBounceSpeed, ForceMode.Force);
        else if(collision.gameObject.CompareTag("RightBoundary"))
            ballRigidbody.AddForce(Vector3.right * -boundryBounceSpeed, ForceMode.Force);
        if(collision.gameObject.name.StartsWith("BigBall")||
            collision.gameObject.name.StartsWith("SmallBall")||
            collision.gameObject.name.StartsWith("SmallestBall"))
        {
            //ballRigidbody.AddForce(Vector3.left * 0.2f, ForceMode.Impulse);
        }
      
    }


}
