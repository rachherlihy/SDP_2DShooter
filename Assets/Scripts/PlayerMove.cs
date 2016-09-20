using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
    public Rigidbody2D rb;
    public Animator anim;
    // set speed in Unity on the component
  	public float speed;
	//public Vector2 speed = new Vector2 (50, 50);

    // get access to the GameObjects Rigidbody component for updates
    public void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();
    }

    // based on key input adjust GameObjects x and y positions
    // to move the player on screen
    public void Update()
    {   
        if (Input.GetKey(KeyCode.W))
        {
            this.rb.MovePosition(this.transform.position + new Vector3(0, speed));
            anim.SetTrigger("left");
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

        //diagonal movements
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            this.rb.MovePosition(this.transform.position + new Vector3(1, 1).normalized*speed);
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            this.rb.MovePosition(this.transform.position + new Vector3(-1, 1).normalized*speed);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            this.rb.MovePosition(this.transform.position + new Vector3(1, -1).normalized*speed);
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            this.rb.MovePosition(this.transform.position + new Vector3(-1, -1).normalized*speed);
        }
		// shooting 
		bool shoot = Input.GetButtonDown ("Fire1");
		shoot |= Input.GetButtonDown ("Fire2");
		if (shoot) 
		{
			WeaponScript weapon = GetComponent<WeaponScript> ();
			if (weapon != null) 
			{
				weapon.Attack (false);
			}
		}

    }



}
