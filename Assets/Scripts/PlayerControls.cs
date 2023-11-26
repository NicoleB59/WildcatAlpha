using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //Declaring variables and referencing the animator component
    private Rigidbody cat;
    public float jumpForce;
    public float gravityModifer;
    public bool isOnGround = true;
    public bool gameOver = false;
    public Animator animator;

    void Start()
    {
        //Getting the components physics and animations
        cat = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifer;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //If space is pressed and is on the ground, object will jump with animation
        //prevent double jumping
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            cat.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            animator.SetBool("IsJumping", true);
        }

        //Otherwise.. cat is on the ground running at default
        else if(!Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            isOnGround = true;
        }
    }

   private void OnCollisionEnter(Collision collision)
    {
        //When cat collided with the ground, animation JUMP stops
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            animator.SetBool("IsJumping", false);
            
        }

        //If cat hits bin, cat gets destroyed
        else if (collision.gameObject.CompareTag("bin"))
        {
            gameOver = true;
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
        
        //If cat collects fish coin, fish coin gets destroyed
        else if (collision.gameObject.CompareTag("fish"))
        {
            Destroy(collision.gameObject);
            Debug.Log("MEOW~");
            //cat shoots furballs
        }
    }
}
