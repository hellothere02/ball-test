using UnityEngine;

public class FinishZone : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.S.WinGame();
        }
    }
}
