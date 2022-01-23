using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject balls;
    public PlayerController playerControl;

    private Vector3 spawnPos;
    private float positionx;
    private float startTime = 1.0f;
    private float intervalTime = 10.0f;

    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ballSpawner", startTime, intervalTime);
    }

    void ballSpawner()
    {
        if (!playerControl.gameOver)
        {
            positionx = Random.Range(-6.7f, 6.7f);
            spawnPos = new Vector3(positionx, transform.position.y, transform.position.z);
            Instantiate(balls, spawnPos, balls.transform.rotation);
        }
    }
   
}
