using UnityEngine;

/// <summary>
/// Контроллер главного меню, загрузка сцены по нажатию кнопки (настроено в редакторе).
/// </summary>
public class MainMenuCanvasController : MonoBehaviour
{
    public void LoadScene()
    {
        new ChangeScene().LoadScene((int)SceneName.LevelGreen);
    }
}
