using UnityEngine;
using System.Collections;

public class ControllerCave : MonoBehaviour {

    private bool isOnGround; // check is player is on the ground

	private int actualCoinCount = 0;

    public float radius = 0.7f; // distanced used
    public float Jumpforce = 400f; // jumping power

    public int lives = 3;

    public Transform groundPoint;

    public LayerMask ground;

    public AudioSource audioSource;
    public AudioClip Jump;
    public AudioClip Fruit;
    public AudioClip Hurt;
    public AudioClip Win;
    public AudioClip GameOver;
    public AudioClip OneUP;

    public Animator animator; // for jump animation
    bool jumped;
    float jumpTime = 0;
    float jumpDelay = 1.0f;

    public int fruitCounter;
    public TextMesh score;
    public TextMesh health;

	public GameObject endGameCanvas;


    // Use this for initialization

    void Start () {
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        isOnGround = Physics2D.OverlapCircle(groundPoint.position, radius, ground);
        if (isOnGround){
            if (Input.GetMouseButtonDown(0)){
                //GetComponent<Rigidbody2D>().AddForce(Vector2.up * Jumpforce);
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * 500);
                jumpTime = jumpDelay;
                jumped = true;
                animator.SetTrigger("jumped"); //change to jump animation

                //PlaySound(Jump);
                audioSource.clip = Jump;
                audioSource.Play();
            }
        }

        jumpTime -= Time.deltaTime;

        if (jumpTime <=0 && isOnGround && jumped) { // restore default walking animation
            animator.SetTrigger("landed");
            jumped = false;
        }
	}

    void OnTriggerEnter2D(Collider2D collider2d)
    {
        if (collider2d.tag == "Fruit") {
            fruitCounter++;
            score.text = "x" + fruitCounter;
            Destroy(collider2d.gameObject);

            audioSource.clip = Fruit;
            audioSource.Play();

			if (fruitCounter % 3 == 0) {
				print ("hej");
				actualCoinCount++;
			}
        }

        if (collider2d.tag == "1UP")
        {
            lives++;
            health.text = "x" + lives;
            Destroy(collider2d.gameObject);
            //PlaySound(OneUP);

            audioSource.clip = OneUP;
            audioSource.Play();
        }


        if (collider2d.tag == "Finish")
        {

            GetComponent<Rigidbody2D>().isKinematic = true;

            audioSource.clip = Win;
            audioSource.Play();
			endGameScreen();
			Coin.updateCoinScore("+", actualCoinCount);
        }

        if (collider2d.tag == "DeathZone") {

            lives--;
            health.text = "x" + lives;

            Destroy(collider2d.GetComponent<Rigidbody2D>());
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 100);
            //animator.SetTrigger("hurt");

            audioSource.clip = Hurt;
            audioSource.Play();

            if (lives == 0)
            {
                animator.SetTrigger("lost");
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * 500);

                Destroy(this.GetComponent<Rigidbody2D>());
                Destroy(this.GetComponent<PolygonCollider2D>());

                audioSource.clip = GameOver;
                audioSource.Play();
				endGameScreen();			

            }
        }

        if (collider2d.tag == "Bounce")
        {
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 500);
            //animator.SetTrigger("hurt");
        }

    }

    public void PlaySound (AudioClip playClip)
    {
        audioSource.clip = playClip;
        audioSource.Play();

    }

	public void endGameScreen(){
		endGameCanvas.SetActive (true);
	}

}