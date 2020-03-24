using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterVechicle : MonoBehaviour
{
    private bool inTrigger = false;
    private Rigidbody2D _rigidBody2D;
    float jumpVelocity = 7.5f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            inTrigger = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            inTrigger = false;
        }
    }
    private void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.E))
        {
            GetComponent<EminemFly>().enabled = false;
            GetComponent<EminemMove>().enabled = true;
            GameObject.Find("Player").GetComponent<PM>().enabled = false;
            GameObject.Find("Player").GetComponent<Vechicle>().enabled = true;
            GameObject.Find("Player").GetComponent<Jump>().enabled = true;
        }
        else if (inTrigger && Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<EminemFly>().enabled = true;
            GetComponent<EminemMove>().enabled = false;
            GameObject.Find("Player").GetComponent<PM>().enabled = true;
            GameObject.Find("Player").GetComponent<Vechicle>().enabled = false;
            _rigidBody2D = GameObject.Find("Player").GetComponent<Rigidbody2D>();
            _rigidBody2D.velocity = Vector2.up * jumpVelocity;
        }
    }
}
