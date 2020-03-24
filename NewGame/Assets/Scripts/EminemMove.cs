using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EminemMove : MonoBehaviour
{
    private float hDir;
    private float vDir;
    [SerializeField] private float Es;

    void Update()
    {
        hDir = Input.GetAxisRaw("Horizontal");
        vDir = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(hDir, vDir, 0) * Time.deltaTime * Es;

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
