using UnityEngine.SceneManagement;

/// <summary>
/// ���������� �������� ����.
/// </summary>
internal class ChangeScene
{
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
