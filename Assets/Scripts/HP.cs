using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    void collide(BoxCollider2D collision)
    {
        bool damagePlayer = false;

        EnemyAI enemy = collision.gameObject.GetComponent<EnemyAI>();
        if (enemy != null)
        {
            PlayerMove player = enemy.GetComponent<PlayerMove>();
            damagePlayer = true;
        }
        if (damagePlayer)
        {
            PlayerMove playerHealth = this.GetComponent<PlayerMove>();
            if (playerHealth != null) playerHealth.SetHealth(10);
        }
    } 
}
