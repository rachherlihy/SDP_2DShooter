using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    private Transform playerPos;
    public float speed;
	
	// Update is called once per frame
	void Update () {
        playerPos = GameObject.Find("Player").transform;
        transform.position = Vector3.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
	}
}
