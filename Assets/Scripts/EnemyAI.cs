using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour
{
    private Transform playerPos;
    public float speed;
    public int attack = 10;
    float cooldownTime = 1;
    bool isCooledDown = true;

    // Update is called once per frame
    void Update()
    {
        playerPos = GameObject.Find("Player").GetComponent<Transform>();
        transform.position = Vector3.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);

        // gets current enemy pos and player pos
        Vector3 enemyPos = this.transform.position;
        Vector3 playerPosV3 = GameObject.FindGameObjectWithTag("Player").transform.position;
        
        // checks to see the distance between the enemy and player
        if (Vector3.Distance(enemyPos, playerPosV3) < 100)
        {   // if enemy has cooled down they can attack the player's health
            if(isCooledDown)
            {
                Debug.Log("--- Player Pos = " + playerPos);
                Debug.Log("--- Enemy Pos = " + enemyPos);
                PlayerMove.health -= attack;
                Debug.Log("--- Health = " + PlayerMove.health);
                isCooledDown = false;
            }
            // set player cooldown to true allowing them to attack again
           else
            {
                cooldownTime -= Time.deltaTime;
                if(cooldownTime <= 0)
                {
                    isCooledDown = true;
                    cooldownTime = 1;
                }
            }
        }
           
    }
    
   // void OnTriggerEnter(Collider other) {
     //   if (other.collider.name == "Player") {
       //     other.transform.GetComponent<HP>().SetHealth(attackDamage);
        //}
    //}
    /*
    void SetAttackTarget(Transform targetTransform) {
        playerPos = targetTransform;
    }
    */
}
