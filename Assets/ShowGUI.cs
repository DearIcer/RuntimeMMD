using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGUI : MonoBehaviour
{
    private Rect rect = new Rect(Screen.width - 410, Screen.height - 200, 400, 130);
    private string text = "模型制作：Nanoda/Kinsama\n动作 Motion：临时映画/AHKちゃん\n镜头 Camera：To_E/ARonisc\n场景：H2CU阿相 _云蜃马戏团·有识月·H2CU式stage12-1\n技术支持：liliToon\n程序编辑：大冰冰水";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUIStyle style = new GUIStyle(GUI.skin.textArea);
        style.wordWrap = true;
        style.fontSize = 12;
        GUI.Box(rect, "借物表");
        GUI.TextArea(new Rect(rect.x + 10, rect.y + 20, rect.width - 20, rect.height - 30), text, style);
    }

}