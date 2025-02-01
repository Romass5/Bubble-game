using UnityEngine;

public class boss_behaviour : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private Vector2 _movement;
    private Rigidbody2D _rb;
    public float max_pos_y, min_pos_y;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * _speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Transform>().position.y > max_pos_y)
        {
            GetComponent<Rigidbody2D>().linearVelocity =  Vector2.down * _speed;
        }
        else if (GetComponent<Transform>().position.y < min_pos_y)
        {
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * _speed;
        }
    }
}
