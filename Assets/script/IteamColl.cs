using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class IteamColl : MonoBehaviour
{  
      private int Ballon=0;
      public static IteamColl instance;
      public TMP_Text BallonText;
      [SerializeField] private AudioSource PopSound;

     void Start()
     {
        BallonText.text="Score: "+Ballon.ToString();
     }
     void Awake()
     {
        instance=this;
     }
     public void IncreaseScore(int v)
     {  
        PopSound.Play();
        Ballon += v;
        BallonText.text="Score: " + Ballon.ToString();
     }
  
  
}
