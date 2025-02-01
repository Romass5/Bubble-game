using UnityEngine;
public class enemy_shoot : MonoBehaviour
{

    public GameObject fire_bullet_spawner;
    public GameObject fire_bulletPrefab;
    public float fire_bulletSpeed = 10f;
    private float rand_shoot;
    public float chance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rand_shoot = Random.Range(0f, chance);
        if (rand_shoot > chance - 1)
        {
            var fire_bullet = Instantiate(fire_bulletPrefab, fire_bullet_spawner.transform.position, fire_bullet_spawner.transform.rotation);
            fire_bullet.GetComponent<Rigidbody2D>().linearVelocity = fire_bullet_spawner.transform.right * fire_bulletSpeed;
            Physics2D.IgnoreCollision(fire_bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
}
