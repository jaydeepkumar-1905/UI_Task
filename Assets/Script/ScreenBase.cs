using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CanvasScreen
{
    Registration,
    LoginPage,
    PointRummy,
    GamePlay,
    MainScreen,
    ExitPopup,

}

public class ScreenBase : MonoBehaviour
{
   
    [HideInInspector]
     public Canvas newCanvas;


   

    private void Awake()
    {
        newCanvas = GetComponent<Canvas>(); 
    }

  
    public void  showScreen()
    {

        newCanvas.enabled = true;
    }

    public void hideScreen()
    {

        newCanvas.enabled = false;
    }

    public static implicit operator ScreenBase(CanvasController v)
    {
        throw new NotImplementedException();
    }
}
