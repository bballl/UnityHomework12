using UnityEngine;

public class LevelBluePlatformLevelEndController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            new ChangeScene().LoadScene((int)SceneName.EndGameMenu);
        }
    }
}
