using UnityEngine;

/// <summary>
/// ����� �� �������� HelpTextActivateTrigger. ��� ��������� ������ � ������� �������� �������� ����� ���������.
/// </summary>
public class HelpTextActivateTriggerController : MonoBehaviour
{
    /// <summary>
    /// ������ HelpText
    /// </summary>
    [SerializeField] private GameObject helpText;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            helpText.SetActive(true);
    }
}
