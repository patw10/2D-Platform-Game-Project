using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private LayerMask PlatformLM;
    float jumpVelocity = 7.5f;
    private Rigidbody2D _rigidBody2D;
    private CircleCollider2D boxC2D;
    public Animator anim;
    void Awake()
    {
        _rigidBody2D = transform.GetComponent<Rigidbody2D>();
        boxC2D = transform.GetComponent<CircleCollider2D>();
    }
    void Update()
    {
        if (isGround() && Input.GetKeyDown(KeyCode.Space))
        {
            _rigidBody2D.velocity = Vector2.up * jumpVelocity;
        }
    }
    private bool isGround()
    {
        RaycastHit2D rayC2D = Physics2D.BoxCast(boxC2D.bounds.center, boxC2D.bounds.size, 0f, Vector2.down, .1f, PlatformLM);

        return rayC2D.collider != null;
    }
}
