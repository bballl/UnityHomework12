using UnityEngine;

/// <summary>
/// �������, ����������� �������� ������� PlugAnimation (�������� ������� � �����) � ����������� ���������.
/// </summary>
public class PlugAnimationTriggerController : MonoBehaviour
{
    [SerializeField] GameObject helpText;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Animation animation = GetComponentInParent<Animation>();
            animation.Play();

            helpText.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
