using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
     [SerializeField] public float speed;
    
    // Start is called before the first frame update
    
     void Start()
     {

     }
    // Update is called once per frame
    void Update()
    {
       Move();
    }

    void Move()
    {
        Vector3 movePos =transform.position;
        movePos.x+=speed*Time.deltaTime;
        transform.position=movePos;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="MainCamera")
        {
            ChangeDirection();
        }

        
    }
    public void ChangeDirection()
    {
        speed *= -1;
    }
}
