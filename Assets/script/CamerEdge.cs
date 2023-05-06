using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerEdge : MonoBehaviour
{
    public float coldep=3f;
     private Vector2 screensize;
     private Transform Top;
     private Transform Bottom;
     private Transform Right;
     private Transform Left;
     public Vector3 cameraPos;
    // Start is called before the first frame update
   private void Start()
   {
         Top=new GameObject().transform;
         Bottom=new GameObject().transform; 
         Right=new GameObject().transform; 
         Left=new GameObject().transform; 

         Top.name="Top";
         Bottom.name="Bottom";
         Right.name="Right";
         Left.name="Left";
        

        Top.gameObject.AddComponent<BoxCollider2D>();
        Bottom.gameObject.AddComponent<BoxCollider2D>();
        Right.gameObject.AddComponent<BoxCollider2D>();
        Left.gameObject.AddComponent<BoxCollider2D>();

        Top.parent=transform;
        Bottom.parent=transform;
        Right.parent=transform;
        Left.parent=transform;

        cameraPos=Camera.main.transform.position;
        screensize.x=Vector2.Distance(Camera.main.ScreenToWorldPoint(new Vector2(0f,0f)),Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,0f)))*0.5f;
        screensize.y=Vector2.Distance(Camera.main.ScreenToWorldPoint(new Vector2(0f,0f)),Camera.main.ScreenToWorldPoint(new Vector2(0f,Screen.height)))*0.5f;

        Right.localScale=new Vector3(coldep,screensize.y * 2, coldep);
        Right.position=new Vector3(cameraPos.x + screensize.x + (Right.localScale.x * 0.5f),cameraPos.y,0f);

       Left.localScale=new Vector3(coldep,screensize.y * 2, coldep);
       Left.position=new Vector3(cameraPos.x - screensize.x - (Left.localScale.x * 0.5f),cameraPos.y,0f);

       Top.localScale=new Vector3(screensize.x * 2, coldep,coldep);
       Top.position=new Vector3(cameraPos.x,cameraPos.y + screensize.y + (Top.localScale.y*0.5f),0f);

       Bottom.localScale=new Vector3(screensize.x * 2, coldep,coldep);
       Bottom.position=new Vector3(cameraPos.x,cameraPos.y - screensize.y - (Bottom.localScale.y*0.5f),0f);
   }

}
