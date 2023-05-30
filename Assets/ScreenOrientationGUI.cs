using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenOrientationGUI : MonoBehaviour
{
    void OnGUI()
    {
        // 计算按钮在屏幕中央的位置
        float buttonWidth = 200;
        float buttonHeight = 50;
        float x = (Screen.width - buttonWidth) / 2;
        float y = (Screen.height - buttonHeight * 2) / 2;

        // 绘制横屏按钮
        if (GUI.Button(new Rect(x, y, buttonWidth, buttonHeight), "固定展示"))
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
            SceneManager.LoadScene("SampleScene");
        }

        // 绘制竖屏按钮
        if (GUI.Button(new Rect(x, y + buttonHeight, buttonWidth, buttonHeight), "自由视角"))
        {
            Screen.orientation = ScreenOrientation.Portrait;
            SceneManager.LoadScene("Scenes/竖屏");
        }
    }
}
