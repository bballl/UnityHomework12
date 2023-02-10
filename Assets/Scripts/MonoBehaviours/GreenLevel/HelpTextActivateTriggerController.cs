using UnityEngine;

/// <summary>
/// Висит на триггере HelpTextActivateTrigger. При попадании игрока в область триггера включает текст подсказки.
/// </summary>
public class HelpTextActivateTriggerController : MonoBehaviour
{
    /// <summary>
    /// Объект HelpText
    /// </summary>
    [SerializeField] private GameObject helpText;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            helpText.SetActive(true);
    }
}
