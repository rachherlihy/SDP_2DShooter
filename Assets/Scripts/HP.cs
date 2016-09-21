using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HP : MonoBehaviour {

    public float minValue;
    public float maxValue;

    public Image HealthBar;
    public float max_health = 100f;
    public float cur_health;

    void Start() {
        cur_health = max_health;
        InvokeRepeating("decreaseHealth",1f, 1f ); // This makes health bar decreases constantly. (decrease health, float time, float repeat time)
        SetHealth();
    }

    void decreaseHealth() {
        cur_health -= 5f; // decreases 5 hp of the player
        SetHealth();
    }

     void SetHealth() {
        float calc_health = cur_health / max_health;
        float output_health = calc_health * (maxValue - minValue) + minValue;

        HealthBar.fillAmount = Mathf.Clamp(output_health, minValue, maxValue);
        
        if (cur_health == 0) {
            Application.LoadLevel("End Scene");
        }
    
    }

    public void Damage(float dmg)
    {
        cur_health -= dmg;
    }

























    //public Image Healthbar;
    //public float max_health = 100f;
    //public float cur_health = 0f;


    /*void Start() {
        cur_health = max_health;
        SetHealthBar();
    }

    public void TakeDamage(float amount) {
        cur_health -= amount;
        SetHealthBar();
    }

    public void SetHealthBar() {
        float my_health = cur_health / max_health;
        Healthbar.fillAmount = my_health;
        if (Input.GetKey(KeyCode.Space)) {
            my_health -= 20f;
        }
    }*/

    /*void Start() {
        cur_health = max_health;
        //SetHealthBar();
    }
    
    public void TakeDamage(float amount) {
        
        float calcHealth = cur_health / max_health;

        cur_health -= amount;
        SetHealthBar(calcHealth);
    }

     void SetHealthBar(float myHealth) {
        Healthbar.fillAmount = myHealth;
     
    }

    void OnTriggerEnter(Collider other) {
        other.gameObject.GetComponent<EnemyAI>();
    }

    void DoDamage() {
        TakeDamage (10f);
    } */
    /*
    void Start() {

        cur_health = max_health;
        //if (gameObject.GetComponent<EnemyAI>()) {

        //}
        //InvokeRepeating("decreaseHealth", 0f, 2f);
    }

    void decreaseHealth() {
        cur_health -= 5f;
        float calcHealth = cur_health / max_health; //70 /100 = 0.7
        SetHealth(calcHealth);
    }

    void SetHealth(float myHealth) {
        Healthbar.fillAmount = myHealth;
    }

    void OnTriggerEnter(Collider other) {
        other.gameObject.GetComponent<EnemyAI>();
    }

    public void TakeDamage(float amount) {
        cur_health -= amount;
    }
    */
}
