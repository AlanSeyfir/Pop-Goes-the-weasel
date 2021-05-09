using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Mathematics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Random = UnityEngine.Random;
using Vector2 = UnityEngine.Vector2;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;
    public GameObject coin;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
    
    private int minY = 1;
    private int maxY = 4;
    
    private float timeBtwSpawn;
    private Vector2 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        int rand = Random.Range(0,obstaclePatterns.Length);
        int spawnCoin = Random.Range(minY, maxY);
        if (timeBtwSpawn <= 0)
        {
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            Instantiate(coin, new Vector2(14f, spawnCoin), Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime;    
            }
            
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
