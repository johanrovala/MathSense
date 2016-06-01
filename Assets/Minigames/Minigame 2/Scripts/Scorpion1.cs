using UnityEngine;
using System.Collections;

public class Scorpion1 : MonoBehaviour {

    private bool isOnGround; // check is object is on the ground

    private float radius = 0.7f; // distanced used
    private float force = 100; // jumping power

    public Transform groundPoint;
    public LayerMask ground;

    GameObject Rigidbody2D;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        isOnGround = Physics2D.OverlapCircle(groundPoint.position, radius, ground);
        if (isOnGround)
        {
           GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
        }

    }
}