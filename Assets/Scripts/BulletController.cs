using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public bool collided = false;

    public int Score;
  

    private float outofBound = 11.8f;
    private float timer;

    public GameObject[] balls;     //balls[0] -> bigBall , balls[2] ->smallball, balls[3] -> smallestball;
    public Animation bulletAnimation;
   
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            DeletingOutofBound();
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.CompareTag("Player"))
        {
            Physics.IgnoreCollision(gameObject.GetComponent<BoxCollider>(), 
                collision.gameObject.GetComponent<CapsuleCollider>());
        }
        else if(collision.gameObject.name.StartsWith("BigBall"))
        {
            for(int i = 0; i < 3; i++)
            {
                Instantiate(balls[1], collision.gameObject.transform.position, balls[1].transform.rotation);
                i++;
            }
            Score += 3;
            collided = true;
            Destroy(collision.gameObject);
        }
        //Debug.Log("CollidingwithAnimation");

        else if(collision.gameObject.name.StartsWith("SmallBall"))
        {
            for (int i = 0; i < 3; i++)
            {
                Instantiate(balls[2], collision.gameObject.transform.position, balls[2].transform.rotation);
                i++;
            }
            Score += 2;
            collided = true;
            Destroy(collision.gameObject);
        }
        else if(collision.gameObject.name.StartsWith("SmallestBall"))
        {
            Score += 1;
            collided = true;
            Destroy(collision.gameObject);
        }

        
    }

    void DeletingOutofBound()
    {
        if (transform.localScale.y > outofBound)
            Destroy(gameObject);
    }    
}
