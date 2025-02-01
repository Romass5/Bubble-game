using UnityEngine;

public class hp_boss : MonoBehaviour
{
    public int hp;
    public GameObject traps;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("bullet"))
        {
            hp--;
        }
        else
        {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }
        if (hp == 0)
        {
            traps.GetComponent<move_trap>()._speed = 10f;
            Destroy(gameObject);
        }
    }

}
