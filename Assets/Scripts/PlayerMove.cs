using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
    public float speed;
    
    void FixedUpdate()
    {
        // set mouse pos to world space
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePos);
        // gives direction for where mouse is looking
        Quaternion rot = Quaternion.LookRotation(transform.position - mousePos, Vector3.forward);
        transform.rotation = rot;
        transform.eurlerAngles = new Vector3(0, 0, transform.eurlerAngles.z);
        GetComponent<Rigidbody2D>().angularVelocity = 0;
    }
}
