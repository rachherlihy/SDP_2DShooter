using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{
    private Transform playerPos;
    public float speed;
    public Rigidbody2D rb;

    // sets enemy to have rigidbody for collisions
    public void Start ()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame and moves enemy towards player
	void Update ()
    {
        playerPos = GameObject.Find("Player").transform;
        transform.position = Vector3.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
	}
}
