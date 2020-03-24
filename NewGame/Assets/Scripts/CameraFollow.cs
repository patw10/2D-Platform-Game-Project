using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector2 velocity;
    public Transform Player;
    public float smoothX;
    public float smoothY;

    private void FixedUpdate()
    {
        if (Player.position.y < -88.50f || Player.position.y < -80.00f)
        {
            transform.position = new Vector3(-97.09f, -84.62f, -10);
        }
        else
        {
            float posX = Mathf.SmoothDamp(transform.position.x, Player.transform.position.x,ref velocity.x, smoothX);
            float posY = Mathf.SmoothDamp(transform.position.y, Player.transform.position.y, ref velocity.y, smoothX);
            transform.position = new Vector3(posX, posY, transform.position.z);
        }

    }
}
