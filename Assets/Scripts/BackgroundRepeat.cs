using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    //Make it more easy to determine the speed of the background
    [Range(-3f,3f)]
    public float scrollSpeed = 0.5f;
    private Material mat;

    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset,0));
    }
}
