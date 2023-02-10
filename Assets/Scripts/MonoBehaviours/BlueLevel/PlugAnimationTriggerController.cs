using UnityEngine;

/// <summary>
/// Триггер, запускающий анимацию объекта PlugAnimation (открытие прохода в стене) и отображение подсказки.
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
