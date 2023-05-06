using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallonMover : MonoBehaviour
{
    [SerializeField] public float speed;
    public int value;
    private float maxSize = 5.0f;
      private float growthRate = 0.3f;
      private float scale= 1.0f;
    // Start is called before the first frame update
    
     void Start()
     {

     }
    // Update is called once per frame
    void Update()
    {   
        Move();
        transform.localScale = Vector3.one * scale;
        scale += growthRate * Time.deltaTime;
        if (scale > maxSize) 
        Destroy (gameObject);
        
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
        if(collision.gameObject.CompareTag("Ballon"))
        {
            Destroy(gameObject);
            IteamColl.instance.IncreaseScore(value);
            completeScene();

        }
    }
    public void ChangeDirection()
    {
        speed *= -1;
    }
    private void completeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
