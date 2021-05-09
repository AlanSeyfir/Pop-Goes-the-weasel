using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MoveCoins : MonoBehaviour
{
    [SerializeField] private float speed = -1.0f;
    private float minY = 1;
    private float maxY = 4;

    public GameObject coinEffect;
    public AudioSource getCoin;
    public AudioSource coin;
    // Start is called before the first frame update
    void Start()
    {
        getCoin = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, 0);
    }

    //Prevent the coin to be in the ground
    private void LateUpdate()
    {
        float spawnCoin = Random.Range(minY, maxY);
        transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, 3);;
    }
    
    private void OnCollisionEnter2D(Collision2D other) {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.tag.Equals("Coin"))
        {
            Instantiate(coinEffect, transform.position, Quaternion.identity);
            getCoin.Play();
            ScoreScripts.score += 10;
            Destroy(gameObject, getCoin.clip.length);

        }
    }
}
