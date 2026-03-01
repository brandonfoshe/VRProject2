using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalUnlock : MonoBehaviour
{
    public int requiredScore = 10;
    public Light portalLight;
    public AudioSource portalAudio;

    private bool isUnlocked = false;

    void Start()
    {
        if (portalLight != null)
        {
            portalLight.enabled = false;
        }
    }

    void Update()
    {
        if (!isUnlocked && ScoreManager.scoreCount >= requiredScore)
        {
            UnlockPortal();
        }
    }

    void UnlockPortal()
    {
        isUnlocked = true;

        if (portalLight != null)
        {
            portalLight.enabled = true;
        }

        if (portalAudio != null)
        {
            portalAudio.Play();
        }
    }

    public void TryEnterPortal()
    {
        if (!isUnlocked) return;

        EndGame();
    }

    void EndGame()
    {
        Debug.Log("Game Over!");
        Application.Quit();
    }
}
