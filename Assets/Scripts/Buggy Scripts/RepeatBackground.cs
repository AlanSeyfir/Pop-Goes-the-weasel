using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector2 startPos;
    private float resetBackground;
    private GameObject background;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        resetBackground = GetComponent<BoxCollider2D>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - resetBackground)
        {
            transform.position = startPos;
        }

    }
}
