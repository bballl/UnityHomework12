using UnityEngine;
using UnityEngine.UI;

public class CanvasGameResultController : MonoBehaviour
{
    void Start()
    {
        Text text = GetComponentInChildren<Text>();

        if (EndGameResult.isGameWin != true)
        {
            text.text = "�� ���������.";
        }
    }

    public void BackToMainMenu()
    {
        new ChangeScene().LoadScene((int)SceneName.MainMenu);
    }
}
