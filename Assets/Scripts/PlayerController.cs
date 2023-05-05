using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public float Speed = 50f;
    private Rigidbody _rb { get; set; }

    private Vector2 _movement;
    
    // Start is called before the first frame update
    void Start() => _rb = GetComponent<Rigidbody>();

    private void FixedUpdate() => _rb.AddForce( new Vector3(_movement.x, 0, _movement.y) * Speed * Time.fixedDeltaTime);

    public void OnMove(InputValue val) => _movement = val.Get<Vector2>();
}
