using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public List<ScreenBase> screenList;

    ScreenBase CanvasScreen;

    public static CanvasController instance;

    private void Awake()
    {
        instance = this;
        CanvasScreen = screenList[0];
    }
    public void showNext(CanvasScreen initialScreen)
    {
        CanvasScreen.hideScreen();
        screenList[(int)initialScreen].showScreen();
        CanvasScreen = screenList[(int)initialScreen];
    }
}
