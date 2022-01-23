using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 20.0f;
    private float bound = 6.785511f;
    private int Health = 5;
    public bool gameOver = false;
    private bool collided = false;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver)
        {
            getInput();
            boundaryLock();
        }
        if (collided)
        {
            Debug.Log("Collided");
            collided = false;
            Health--;
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("BigBall") ||
            collision.gameObject.name.StartsWith("BiggestBall") ||
            collision.gameObject.name.StartsWith("SmallestBall"))

            if (Health > 1)
                collided = true;
            else
            {
                gameOver = true;
                Destroy(gameObject);
            }

    }






    void getInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        
    }

    
    void boundaryLock()
    {

        if (transform.position.x < -bound)
            transform.position = new Vector3(-bound, transform.position.y, transform.position.z);
        if (transform.position.x > bound)
            transform.position = new Vector3(bound, transform.position.y, transform.position.z);
    }
}
