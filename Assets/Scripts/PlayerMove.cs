using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
    public Rigidbody2D rb;
    // set speed in Unity on the component
    public float speed;

    // get access to the GameObjects Rigidbody component for updates
    public void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // based on key input adjust GameObjects x and y positions
    // to move the player on screen
    public void Update()
    {   
        if (Input.GetKey(KeyCode.W))
        {
            this.rb.MovePosition(this.transform.position + new Vector3(0, speed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.rb.MovePosition(this.transform.position + new Vector3(0, -speed));
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.rb.MovePosition(this.transform.position + new Vector3(-speed, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.rb.MovePosition(this.transform.position + new Vector3(speed, 0));
        }
    }

}
