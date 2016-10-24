using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour
{
    public Transform shotPrefab;
    /// Cooldown in seconds between two shots
    public float shootingRate = 0.25f;
    // 2  Cooldown
    private float shootCooldown;

    void Start()
    {
        shootCooldown = 0f;
    }

    void Update()
    {
        if (shootCooldown > 0)
        {
            shootCooldown -= Time.deltaTime;
        }
    }

    public void Attack(bool isEnemy)
    {
        if (CanAttack)
        {
            shootCooldown = shootingRate;
            // Create a new shot
            var shotTransform = Instantiate(shotPrefab) as Transform;
            // Assign position
            shotTransform.position = transform.position;
            // The is enemy property
            ShotScript shot = shotTransform.gameObject.GetComponent<ShotScript>();
            if (shot != null)
            {
                shot.isEnemyShot = isEnemy;
            }
            // Make the weapon shot always towards it
            BulletMove move = shotTransform.gameObject.GetComponent<BulletMove>();
            if (move != null)
            {
                //Get the mouse
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos = new Vector3(mousePos.x, mousePos.y, 0);

                //Rotate the sprite to the mouse point
                Vector3 diff = mousePos - transform.position;
                diff.Normalize();
                float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;

                // Save the old value
                var temp = transform.rotation;

                transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

                //Move the sprite towards the mouse
                move.direction = transform.up;

                // Restore the old value
                transform.rotation = temp;
            }
        }
    }

    public bool CanAttack
    {
        get
        {
            return shootCooldown <= 0f;
        }
    }
}