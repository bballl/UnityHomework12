using UnityEngine;

/// <summary>
/// ���������� �������� ����, �������� ����� �� ������� ������ (��������� � ���������).
/// </summary>
public class MainMenuCanvasController : MonoBehaviour
{
    public void LoadScene()
    {
        new ChangeScene().LoadScene((int)SceneName.LevelGreen);
    }
}
