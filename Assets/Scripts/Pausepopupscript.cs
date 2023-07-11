using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausepopupscript : MonoBehaviour
{
    public Transform box;
    public CanvasGroup background;
    [SerializeField] GamePausePlay PausePlayScript;
 


    public void CloseDialog()
    {
        gameObject.SetActive(false);
      
    }
   
}
