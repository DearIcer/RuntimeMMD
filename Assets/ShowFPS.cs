using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFPS : MonoBehaviour
{
    private Rect fpsRect = new Rect(Screen.width - 110, 10, 100, 50);
    private string title = "FPS";
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnGUI()
    {
        GUIStyle style = new GUIStyle(GUI.skin.box);
        style.alignment = TextAnchor.MiddleCenter;
        GUI.Box(fpsRect, title, style);

        float fps = 1.0f / Time.deltaTime;
        GUI.Label(new Rect(fpsRect.x + 10, fpsRect.y + 20, 80, 20), ((int)fps).ToString());
    }
}
