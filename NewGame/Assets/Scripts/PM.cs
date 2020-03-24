using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PM : MonoBehaviour
{
    public float Ps = 5;
    private float hDir;
    private Rigidbody2D _rigidBody2D;
    private Collider2D boxC2D;
    public Animator anim;

    void Update()
    {
        hDir = Input.GetAxisRaw("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(hDir));
        transform.position += new Vector3(hDir, 0, 0) * Time.deltaTime * Ps;

        Vector3 chScale = transform.localScale;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            chScale.x = -1f;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            chScale.x = 1f;
        }
        transform.localScale = chScale;

    }
}