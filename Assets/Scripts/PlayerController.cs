using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 3.0f;
    [SerializeField] private float jumpForce = 10.0f;
    private Rigidbody2D playerRb;
    private Animator anim;
    private GameObject gameOverScreen;

    public AudioSource explosion;
    public AudioSource audioSource;
    public AudioSource getCoin;
    public int health = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        explosion = GetComponent<AudioSource>();
        getCoin = GetComponent<AudioSource>();
    }

    /*public void CallLoadNextScene()
    {
        Invoke("LoadNextScene", delayScene);
    }

    public void LoadNextScene()
    {
        
    }*/

    IEnumerator ChangeScene(int index, float delay = 2f)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(index);
        //SceneManager.LoadScene("GameOver");
    }
    
    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            //If I want to call the Game over scene
            //StartCoroutine(ChangeScene(2));
            //Time.timeScale = 0;
            SceneManager.LoadScene("GameOver");
        }
        
        float movement = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(movement * speed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");//AQUI
            playerRb.AddForce(new Vector2(0,jumpForce),ForceMode2D.Impulse);
            audioSource.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag.Equals("Coin"))
        {
            
        }

        if (gameObject.CompareTag("Obstacle"))
        {
            explosion.Play();
        }
    }
}
