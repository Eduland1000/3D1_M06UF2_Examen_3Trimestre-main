using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();

        animator = GetComponent<Animator>();
    }

 void Movement()
{
	if(inputHorizontal < 0)
       	 {
       	     //render.flipX = true;
       	     transform.rotation = Quaternion.Euler(0, 180,0);
       	     anim.SetBool("IsRunning", true);
       	 }
        	else if(inputHorizontal > 0)
        	{
        	    //render.flipX = false;
        	    transform.rotation = Quaternion.Euler(0, 0,0);
        	    anim.SetBool("IsRunning", true);
        	}
        	 else 
       	 {
        	    anim.SetBool("IsRunning", false);
       	 }

}

void Jump()
    {
         if(Input.GetButtonDown("Jump") && sensor.isGrounded == true)
        {
               rBody.AddForce(new Vector2(0,1) * jumpForce, ForceMode2D.Impulse);   
               anim.SetBool("IsJumping", true);
               source.PlayOneShot(jumpSound);
        }
    }
}
