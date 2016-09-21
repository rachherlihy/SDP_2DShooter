using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    private Transform playerPos;
    public float speed;





    //float damage = 5f;
    // public float attackRange = 3.5f;
    //public float attackDamage = 10f;

    // Update is called once per frame
    void Update()
    {
        playerPos = GameObject.Find("Player").GetComponent<Transform>();
        transform.position = Vector3.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
        //if(Vector3.Distance(transform.position, playerPos.position,))
        
        
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
