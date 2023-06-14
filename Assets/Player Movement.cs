using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;
public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed;
    public Vector2 movementInput;
    public Rigidbody2D rigidBody;
    public Animator anim;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("ForwardAnimation");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("BackwardAnimation");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("LeftAnimation");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("RightAnimation");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {

        }
    }
    
    private void FixedUpdate()

    {
        rigidBody.velocity = movementInput * moveSpeed;
    }
    private void OnMove(InputValue inputValue)
    {
        movementInput = inputValue.Get<Vector2>();
    }
}
