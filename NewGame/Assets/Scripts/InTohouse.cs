using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InTohouse : MonoBehaviour
{
    private bool inTrigger = false;
    [SerializeField] private Vector3 doorposition;
    [SerializeField] private Transform player;
    public GameObject Image;
    private Animator anim;
    private void Awake()
    {
        anim = Image.GetComponent<Animator>();
    }
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

    void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.E))
        {

            FadeIn();
            Invoke(nameof(Goto), 0.5f);
            Invoke(nameof(FadeOut),1f);
        }
    }
        void Goto()
        {
            GameObject.Find("Main Camera").transform.position = new Vector3(-97.09f, -84.62f, -10f);
            player.position = doorposition;
        }
        void FadeOut()
        {
            anim.SetBool("FadeI", false);
            anim.SetBool("FadeO", true);
        }
        void FadeIn()
        {
            anim.SetBool("FadeI", true);
            anim.SetBool("FadeO", false);
        }
}
