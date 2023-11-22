using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 0.5f;
    public float gravityModifier;
    public bool IsOnGround = true;
    public bool gameOver = false;

    
    public AudioClip bark;
    public AudioClip crash;
    public AudioSource player;
    private SpawnManager spawnManager;
    public bool hasPower;
    public int powerDuration = 5;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        player = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& IsOnGround  && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            IsOnGround = false;
        }

    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground") && !gameOver)
        {
            IsOnGround = true;
          
        }
        else if (other.gameObject.CompareTag("Fence"))
        {
            gameOver = true;
            player.PlayOneShot(crash, 1.0f);
            player.Stop();



        }
        else if (other.gameObject.CompareTag("Bone"))
        {
            
            player.PlayOneShot(bark, 1.0f);
            Destroy(other.gameObject);
            

        }
        else if (other.gameObject.CompareTag("Ball"))
        {
            player.PlayOneShot(bark, 1.0f);
            Destroy(other.gameObject);



        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {

            hasPower = true;
            float delaySpawn = .25f;
            float interval = .5f;
            spawnManager.InvokeRepeating("SpawnFoodObjects", delaySpawn, interval);
            StartCoroutine(PowerUpCool());

        }
        if (other.gameObject.CompareTag("Bone"))
        {
            Destroy(other.gameObject);

        }
    }
    IEnumerator PowerUpCool()
    {
        yield return new WaitForSeconds(powerDuration);
        hasPower = false;
    }

}
