using UnityEngine;

/// <summary>
/// ����� �� ������� GateButtonTrigger, ������������ ��������� ������ � ������� ��������. 
/// � ���� ������ � ������� GateAnimator �������� ����� �������� - ���������� �������� ����� (������� �� ���� GateOpen).
/// </summary>
public class GateButtonTriggerController : MonoBehaviour
{
    /// <summary>
    /// �������� true ������������� ���������� ������ � ������� ��������.
    /// </summary>
    private bool flag;
    private void Awake()
    {
        Observer.ActivateButtonPressed += ChangeAnimationClip;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            flag = true;
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
            flag = false;
    }

    private void ChangeAnimationClip()
    {
        if (flag == true)
        {
            Animator animator = GetComponentInParent<Animator>();
            animator.SetBool("isGateButtonDown", true);
        }
    }
}
