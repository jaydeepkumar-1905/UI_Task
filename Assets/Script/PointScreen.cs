using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointScreen : ScreenBase
{
    public Button playBtn;

    public void loginbutton_OnClick()
    {
        CanvasController.instance.showNext(CanvasScreen.GamePlay);
    }

    public void Start()
    {
        playBtn.onClick.AddListener(loginbutton_OnClick);
    }

}
