using Unity.VisualScripting;
using UnityEngine;

public class spawn_boss : MonoBehaviour
{
    public Transform spawnBoss;
    public GameObject bossPrefab;
    private bool boss_rat_spawned;
    public GameObject traps;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals("spawn_boss_rat"))
        {
            traps.GetComponent<move_trap>()._speed = 0f;
            bossPrefab.transform.position = new Vector3(6f, bossPrefab.transform.position.y, bossPrefab.transform.position.z);
            bossPrefab.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            Destroy(collider.gameObject);
            Destroy(gameObject);        }
    }
}
