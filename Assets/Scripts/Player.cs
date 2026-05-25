using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float movementSpeed = 10f;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _rb.linearVelocity = new Vector2 (Input.GetAxis("Horizontal") * movementSpeed, _rb.linearVelocityY);
    }
}
