using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Animator anim;
    public GameObject potion;
    public PlayerMovement playerMovement;
    public int HealthIncrease;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerHeal();
            //anim.SetBool("isActive", true);
            potion.SetActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //anim.SetBool("isActive", false);
        }
    }

    public void PlayerHeal()
    {
        playerMovement.healthPoints = playerMovement.healthPoints + HealthIncrease;
    }
}