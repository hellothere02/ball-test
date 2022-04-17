using UnityEngine;

public class DeadlyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.S.loseGame();
        }
    }
}
