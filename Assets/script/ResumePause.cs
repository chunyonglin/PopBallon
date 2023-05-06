using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumePause : MonoBehaviour
{
    public GameObject PauseResume;
    bool gamePause;
    // Start is called before the first frame update
    void Start()
    {
        gamePause=false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gamePause)
        Time.timeScale=0;
        else
        Time.timeScale=1;
    }
    public void Pause()
    {
       gamePause=true;
       PauseResume.SetActive(true);
    }
    public void Resume()
    {
        gamePause=false;
        PauseResume.SetActive(false);
    }
    
}
