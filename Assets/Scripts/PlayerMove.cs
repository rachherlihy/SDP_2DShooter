using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {

    //public Image Healthbar;
    //public int startHealth = 100;
    //public int currentHealth;
    public static int health;
    public Rigidbody2D rb;
    public Animator anim;

    //bool isDead;
    //bool damaged;
    // set speed in Unity on the component
  	public float speed;
	//public Vector2 speed = new Vector2 (50, 50);

    // get access to the GameObjects Rigidbody component for updates
    public void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();
        health = 100;
        //SetHealthBar();
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
        // TakeDamage();


    }
   

    /*void Awake() {
        currentHealth = startHealth;
    }

    public void TakeDamage(int amount = 20) {
        damaged = true;
        if (Input.GetKeyDown(KeyCode.P))
        {
            currentHealth -= amount;

            Healthbar.fillAmount = currentHealth;
        }
    
        if (currentHealth <= 0) {
            Death();
        }

 
    }

    void Death() {
        isDead = true;
        Application.LoadLevel("End Scene");
    }
    */

    /*public void TakeDamage(int amount)
    {
        cur_health -= amount;
        //SetHealthBar();
    }

    public void SetHealthBar()
    {
        cur_health = max_health;
        //float my_health = cur_health / max_health;
        Healthbar.fillAmount = max_health;
        if (Input.GetKey(KeyCode.Space))
        {
            max_health -= 2;
         //   my_health -= 20f;
        }
    }*/

    /*void hit(int damage = 20) {
        currentHealth -= damage;
        //currentHealth.fillAmount -=damage;
    }

    public void decreaseHealth() {
        currentHealth -= 2;
        float calculateHealth = currentHealth/maxHealth;
    }
    
    */


}
