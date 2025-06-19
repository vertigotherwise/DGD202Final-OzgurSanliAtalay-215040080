using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMover : MonoBehaviour
{
    private Rigidbody _rigidbody;
    
    [Header("Movement Parameters")]
    [field: SerializeField] public float MoveSpeed { get; private set; }
    [SerializeField] private float _turnSpeed;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector2 direction)
    {
        float moveX = direction.x;
        float moveZ = direction.y;

        transform.Rotate(Vector3.up, moveX * _turnSpeed * Time.deltaTime, Space.World);
        
        _rigidbody.linearVelocity = transform.forward * (moveZ * MoveSpeed);
    }
}
