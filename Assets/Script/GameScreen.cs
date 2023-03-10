using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScreen : ScreenBase
{
    public Button exitBtn;

    public void loginbutton_OnClick()
    {
        CanvasController.instance.showNext(CanvasScreen.LoginPage);
    }

    public void Start()
    {
        exitBtn.onClick.AddListener(loginbutton_OnClick);
    }

}
