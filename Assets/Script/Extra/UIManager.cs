using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIManager : MonoBehaviour
{
    //public List<ScreenView> screenList;
    //public Canvas currentScreenCanvas;
    //public static UIManager instance;
 
    //public void Awake()
    //{
    //    instance = this;
    //}
    //private void Start()
    //{

       
    //}

    public void Toggelescreeen(Canvas canvas)
    {
        canvas.enabled =! canvas.enabled;
    }

    //public void ShowScreen(Screen screen)
    //{
    //    if (currentScreenCanvas != null)
    //    {
    //        currentScreenCanvas.enabled = false;
            
    //    }
    //    currentScreenCanvas = screenList.Find(x => x.screenEnum == screen).screenCanvas;
    //    currentScreenCanvas.enabled = true;
        
    //}
    //public enum Screen
    //{
    //    PointRummy,
    //    MainScreen,
    //    Registration_Page,
    //    LoginPage,
    //    GamePlay,
    //    ExitPopup,

    //}
    ////[System.Serializable]
    //public class ScreenView
    //{
    //    public Screen screenEnum;
    //    public Canvas screenCanvas;
    //}

}
    