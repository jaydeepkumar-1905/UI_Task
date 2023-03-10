using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoginScreen : ScreenBase
{

        public Button loginButton,moveLobbyBtn;

        public void Loginbutton_OnClick()
        {
          CanvasController.instance.showNext(CanvasScreen.LoginPage);
        }
       public void moveLobby_OnClick()
       {
        CanvasController.instance.showNext(CanvasScreen.PointRummy);
        }

    public void Start()
        {
            loginButton.onClick.AddListener(Loginbutton_OnClick);
            moveLobbyBtn.onClick.AddListener(moveLobby_OnClick);
    }
     
}
