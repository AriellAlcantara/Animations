using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedpotion : MonoBehaviour
{
    public Animator anim;
    public GameObject Speedpot;
    public PlayerMovement playerMovement;
    public int speedincrease;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Movefast();
            //anim.SetBool("isActive", true);
            Speedpot.SetActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //anim.SetBool("isActive", false);
        }
    }

    public void Movefast()
    {
        playerMovement.moveSpeed = playerMovement.moveSpeed + speedincrease;
    }
}
