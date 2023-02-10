using UnityEngine.SceneManagement;

/// <summary>
/// Контроллер загрузки сцен.
/// </summary>
internal class ChangeScene
{
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
