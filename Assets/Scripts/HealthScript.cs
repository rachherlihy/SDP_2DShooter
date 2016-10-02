using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour
{
	public int hp = 2;
	public bool isEnemy = true;
    public ScoreManager sm;

    void Start() {
        sm = FindObjectOfType<ScoreManager>();
    }

	void OnTriggerEnter2D(Collider2D collider)
	{
		ShotScript bullet = collider.gameObject.GetComponent<ShotScript> ();

		if (bullet != null) 
		{
			if (bullet.isEnemyShot != isEnemy) 
			{
				hp -= bullet.damage;
				Destroy (bullet.gameObject);
				if (hp <= 0) 
				{
                    Destroy (gameObject);
                    sm.addToScore();
                }
			}
		}
	}
}
