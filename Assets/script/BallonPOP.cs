using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonPOP : MonoBehaviour


{

    private Animator anim;
    // Start is called before the first frame update
   private void Start()
    {
        anim=GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            Die();
        }
    }
     private void Die()
    {
        anim.SetTrigger("pop");
    }
}
