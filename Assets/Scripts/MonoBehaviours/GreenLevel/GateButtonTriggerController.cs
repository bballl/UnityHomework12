using UnityEngine;

/// <summary>
/// Висит на объекте GateButtonTrigger, обрабатывает попадание игрока в область триггера. 
/// В этом случае у объекта GateAnimator анимация ворот меняется - происходит открытие ворот (переход на клип GateOpen).
/// </summary>
public class GateButtonTriggerController : MonoBehaviour
{
    /// <summary>
    /// Значение true соответствует нахождению игрока в области триггера.
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
