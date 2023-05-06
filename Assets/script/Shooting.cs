using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{     

    private Camera mainca;
    private Vector3 mousePos;
    public GameObject bullets;
    public Transform bulletpos;
    public bool isFire;
    private float timer;
    public float timeFire;
    // Start is called before the first frame update
    void Start()
    {
        mainca=GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos=mainca.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos-transform.position;

        float rotz=Mathf.Atan2(rotation.y,rotation.x) * Mathf.Rad2Deg;

        transform.rotation=Quaternion.Euler(0,0,rotz);

        if(!isFire)
        {
            timer+=Time.deltaTime;
            if(timer> timeFire)
            {
                isFire=true;
                timer=0;
            }
        }


        if(Input.GetMouseButton(0) && isFire)
        {
            isFire=false;
            Instantiate(bullets,bulletpos.position,Quaternion.identity);
        }
    }
}
