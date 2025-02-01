using UnityEngine;
using UnityEngine.InputSystem;
public class movement_cs : MonoBehaviour
{
    public static Vector2 Movement;
    public PlayerInput _playerInput;
    private InputAction _moveAction;
    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _moveAction = _playerInput.actions["move"];
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement = _moveAction.ReadValue<Vector2>();
    }
}
