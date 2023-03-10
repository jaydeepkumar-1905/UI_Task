using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UiTranslate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Registrtion,Login,Main,ExitPopup,Point,Game;
   
    void Start()
    {
       
        CloseScreen();
        Registrtion.SetActive(true);
    }

    public void CloseScreen() {
        Registrtion.SetActive(false);
        Login.SetActive(false);
        Game.SetActive(false);
        Main.SetActive(false);
        ExitPopup.SetActive(false);
        Point.SetActive(false);
    }


    // Update is called once per frame
    public void  ActiveLogin()
    {
        CloseScreen();
        Login.SetActive(true);
        
    }

    public void ActiveRegistration()
    {
        CloseScreen();
        Registrtion.SetActive(true);
    }


    public void ActiveLobby()
    {
        CloseScreen();
        Point.SetActive(true);
    }

    public void ActiveGame()
    {
        CloseScreen();
        Game.SetActive(true);
    }

    public void ActiveMain()
    {
        CloseScreen();
        Point.SetActive(true);
        Main.SetActive(true);
    }

    public void ActiveExitPopup()
    {
        CloseScreen();
        Game.SetActive(true);
        ExitPopup.SetActive(true);
        
    }
}
