using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidingWithBall : MonoBehaviour
{
    public Rigidbody ballRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.y > 7)
            ballRigidBody.AddForce(Vector3.down * 5);
           
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }

}
