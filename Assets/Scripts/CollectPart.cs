using UnityEngine;

public class CollectPart : MonoBehaviour

// Script written by Brandon Foshe

/* <summary>
 * 
 * While hovering over part && NOT collected - 
 * Collect part by disabling it
 * Play a sound maybe?
 * Enable finished part (attached to portal)
 * collected = true (so it can't be recollected)
 */

{
	// When script is applied, set its part number and its old and new game object (for enabling / disabling)
	[SerializeField]
	int partNum = 0;
	[SerializeField]
	GameObject originalPart, fixedPart;
	[SerializeField]
	AudioClip pickup, hint;
	[SerializeField]
	AudioSource newAudioSource;

	bool collected = false;
	AudioSource source;

	void Start()
	{
		source = GetComponent<AudioSource>();
	}

	public void Collect()
	{
		if (!collected)
		{

			// Play sound
			newAudioSource.PlayOneShot(pickup);
			originalPart.SetActive(false);
			StaticData.Collect(partNum);
			fixedPart.SetActive(true);
			collected = true;

		}
	}

	public void hintSound()
	{
		// Play a low rumble hint sound when hovering on object
		source.PlayOneShot(hint);
	}

	public void stopRumble()
	{
		source.Stop();
	}
}
