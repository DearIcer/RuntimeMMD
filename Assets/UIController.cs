using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    private Rect resetRect = new Rect(10, 10, 100, 50);
    private string resetTitle = "复位";

    private Rect quitRect = new Rect(120, 10, 100, 50);
    private string quitTitle = "退出";

    void OnGUI()
    {
        if (GUI.Button(resetRect, resetTitle))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (GUI.Button(quitRect, quitTitle))
        {
            Application.Quit();
        }
    }
}
