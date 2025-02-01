using UnityEngine;
public class player_move : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    private Vector2 _movement;
    private Rigidbody2D _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _movement.Set(movement_cs.Movement.x, movement_cs.Movement.y);

        _rb.linearVelocity = _movement * _moveSpeed;
    }
}
