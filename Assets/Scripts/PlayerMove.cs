using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public Image Healthbar;
    public static float startHealth = 100f;
    public static float currentHealth = 0f;
    public Rigidbody2D rb;
    private Animator anim;
    public bool isDead = false;

    // set speed in Unity on the component
  	public float speed;

    // get access to the GameObjects Rigidbody component for updates
    public void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        currentHealth = startHealth;
        Healthbar.fillAmount = currentHealth;
        anim = this.GetComponent<Animator>();
    }

    // based on key input adjust GameObjects x and y positions
    // to move the player on screen
    public void Update()
    {   
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetInteger("Direction", 2);
            this.rb.MovePosition(this.transform.position + new Vector3(0, speed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetInteger("Direction", 0);
            this.rb.MovePosition(this.transform.position + new Vector3(0, -speed));
        }
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetInteger("Direction", 3);
            this.rb.MovePosition(this.transform.position + new Vector3(-speed, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetInteger("Direction", 1);
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

        // updates the health bar displayed on the screen
        Healthbar.GetComponent<Image>().fillAmount = currentHealth / 100f;
        // if player health hits 0, checks if new highscore and
        // adds it to the list if so then or, otherwise loads end screen
        if (currentHealth <= 0f)
        {
            // check to see if a new highscore and add to list if so
            isDead = true;
            Debug.Log(" Player is dead ");
            Application.LoadLevel("End Scene");
        }  
    }

    // CHECK??
    public void SetHealth(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0f)
        {
            Application.LoadLevel("End Scene");
        }
    }
   
}
