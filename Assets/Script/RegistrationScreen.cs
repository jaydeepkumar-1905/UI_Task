using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RegistrationScreen : ScreenBase
{

        public Button loginButton;

        public void loginbutton_OnClick()
        {
          CanvasController.instance.showNext(CanvasScreen.Registration);
        }

        public void Start()
        {
            loginButton.onClick.AddListener(loginbutton_OnClick);
        }
     
}
