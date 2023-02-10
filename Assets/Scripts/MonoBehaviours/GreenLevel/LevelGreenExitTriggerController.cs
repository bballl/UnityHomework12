using UnityEngine;

public class LevelGreenExitTriggerController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Animator animator = GetComponentInParent<Animator>();
        animator.SetBool("isLevelEnd", true);

        float delay = 3.1f;
        Invoke("LevelEnd", delay);
    }
    /// <summary>
    /// Загрузка следующего уровня.
    /// </summary>
    private void LevelEnd()
    {
        new ChangeScene().LoadScene((int)SceneName.LevelBlue);
    }
}
