using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
    public GameObject player;
    private Vector3 distance;

	// Use this for initialization
	void Start () {
        distance = transform.position - player.transform.position;
	}
	
	void LateUpdate () {
        transform.position = player.transform.position + distance;
	}
}
