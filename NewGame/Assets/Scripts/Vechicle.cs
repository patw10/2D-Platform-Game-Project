using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vechicle : MonoBehaviour
{
    public Transform vechicle;
    void Update()
    {
        transform.position = new Vector3(vechicle.position.x - 0.18f, vechicle.position.y + 0.737f, 0);
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
