using UnityEngine;

public class move_trap : MonoBehaviour
{
    [SerializeField] public float _speed = 0.65f;      


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
