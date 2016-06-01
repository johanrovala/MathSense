using UnityEngine;
using System.Collections;

public class Scorpion : MonoBehaviour {

    private bool isOnGround; // check is player is on the ground

    private float radius = 0.7f; // distanced used
    private float force = 200; // jumping power

    public Transform groundPoint;
    public LayerMask ground;

    bool jumped;
    float jumpTime = 0;
    float jumpDelay = 1.0f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        isOnGround = Physics2D.OverlapCircle(groundPoint.position, radius, ground);
        if (isOnGround)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
            jumpTime = jumpDelay;
        }
        jumpTime -= Time.deltaTime;

    }
}
