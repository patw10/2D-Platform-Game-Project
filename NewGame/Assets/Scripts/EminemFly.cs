using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EminemFly : MonoBehaviour
{
    [SerializeField] private float ESpeed;
    float timeLeft = 2;
    int dir = 1;

    void FixedUpdate()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft > 0)
        {
            if (dir == 1)
            {
                transform.position += new Vector3(1, 0, 0) * Time.deltaTime * ESpeed;
            }
            else if (dir == 0)
            {
                transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * ESpeed;
            }
        }
        else if (timeLeft < 0)
        {
            timeLeft = 2;
            if (dir == 1)
            {
                dir = 0;
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                dir = 1;
                transform.localScale = new Vector3(1, 1, 1);
            }

        }
    }
}