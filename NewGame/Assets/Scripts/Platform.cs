using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private bool inTrigger = false;

    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            inTrigger = true;
        }

    }
    void Update()
    {
        if(inTrigger && Input.GetKeyDown(KeyCode.S) || inTrigger && Input.GetKeyDown(KeyCode.DownArrow))
        {
            Jumper();
            Invoke(nameof(Jumper), 0.5f);
        }
    }
    public void Jumper()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = !gameObject.GetComponent<BoxCollider2D>().enabled;
    }

}
