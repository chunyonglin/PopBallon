using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] private Rigidbody2D rb;
   [SerializeField] private float hz=0f;
   [SerializeField] private Animator anim;
   [SerializeField] private SpriteRenderer sp;
   [SerializeField] private float speed=7f;
   [SerializeField] private float jump=14f;

   private enum movestate {idle,running,jumping,falling}
 
    
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();
        sp=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
   private void Update()
    {
         hz = Input.GetAxisRaw("Horizontal");
         rb.velocity=new Vector2(hz * speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity=new Vector2(rb.velocity.x,jump);
        }
        updateAnimator();

    }

    private void updateAnimator()
    { 
          movestate state;
        if (hz > 0f)
        {
            state=movestate.running;
            sp.flipX=false;
        }
        else if (hz < 0f)
        {
            state=movestate.running;
            sp.flipX=true;
        }
        else
        {
            state=movestate.idle;
        }

        if(rb.velocity.y>.1f){
            state=movestate.jumping;
        }
        else if(rb.velocity.y<-.1f){
            state=movestate.falling;

        }
        anim.SetInteger("state",(int)state);
    }
   
}
