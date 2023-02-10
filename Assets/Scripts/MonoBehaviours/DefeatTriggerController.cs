using UnityEngine;

/// <summary>
/// ������� ��������� ���������.
/// </summary>
public class DefeatTriggerController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        EndGameResult.isGameWin = false;
        new ChangeScene().LoadScene((int)SceneName.EndGameMenu);
    }
}
