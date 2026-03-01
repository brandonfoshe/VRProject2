using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalLogic : MonoBehaviour

// Script written by Brandon Foshe

/* <summary>
 * 
 * If all 4 parts collected - 
 * Enable portal inner
 * When hovering on portal && click -
 * Transfer to next level
 */
    
{

	[SerializeField]
	GameObject PortalInner, PortalErrorMessage;
	[SerializeField]
	AudioClip portalSound;

	bool active = false;
	bool messagePoppedUp = false;
	bool portalSoundPlayed = false;

	AudioSource source;

	void Start()
	{
		source = GetComponent<AudioSource>();
	}

	void Update()
    {
        if (!active)
        {
			// Checks if all parts have been collected, then disables this path when true
			if (StaticData.CheckAll())
			{
				PortalInner.SetActive(true);
				active = true;
			}
		}
		if(active && !portalSoundPlayed)
		{
			// Play portal sound when portal is triggered for the first time
			source.PlayOneShot(portalSound);
			portalSoundPlayed = true;
		}
    }

	// Trigger on portal hover click
	public void ProceedToNextLevel()
	{
		if (active)
		{
			SceneManager.LoadScene("Level2");
		}
		else
		{
			PortalErrorMessage.SetActive(true);
			messagePoppedUp = true;
		}
	}

	public void CloseMessage()
	{
		if (messagePoppedUp)
		{
			PortalErrorMessage.SetActive(false);
			messagePoppedUp = false;
		}
	}
}
