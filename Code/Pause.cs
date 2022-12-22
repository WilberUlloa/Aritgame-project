using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseObject;

    public void pause()
    {
        pauseObject.SetActive(true);
        Time.timeScale = 0; 
    }

    public void Nopause()
    {
        pauseObject.SetActive(false);
        Time.timeScale = 1;
    }

}
