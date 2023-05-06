using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public float Speed = 500f;
    public float BoostAmt = 5f;
    
    private Rigidbody _rb { get; set; }

    private Vector2 _movement;
    private Vector3 _movementXZ => new Vector3(_movement.x, 0, _movement.y);
    
    // Start is called before the first frame update
    void Start() => _rb = GetComponent<Rigidbody>();

    private void FixedUpdate()
    {
        _rb.AddForce(_movementXZ * Speed * Time.fixedDeltaTime);
    }

    public void OnMove(InputValue val) => _movement = val.Get<Vector2>();

    public void OnBoost(InputValue val)
    {
        Debug.Log("Boost");
        
        _rb.AddForce(_movementXZ * BoostAmt, ForceMode.Impulse);
    }
}
