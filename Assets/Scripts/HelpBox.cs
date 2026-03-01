using UnityEngine;

public class HelpBox : MonoBehaviour

    // Script written by Brandon Foshe

    /* <summary>
     * 
     * While helpbox is being hovered over -
     * When click on the helpbox, disable the exclamation indicator (if it hasn't already)
     * Display text
     * Close text on click
     */
{
    [SerializeField]
    GameObject Exclamation, HelpText;
    [SerializeField]
    AudioClip intro, outro;

    bool notif = true;
    bool messageUp = false;

	AudioSource source;

	void Start()
	{
		source = GetComponent<AudioSource>();
	}

	public void OnClick()
    {
        if (notif)
        {
            Exclamation.SetActive(false);
            notif = false;
        }
        if (!messageUp)
        {
			//Play sound
			source.PlayOneShot(intro);
			HelpText.SetActive(true);
            messageUp = true;
		}
    }

    public void CloseMessage()
    {
        if (messageUp)
        {
			// Play sound
			source.PlayOneShot(outro);
			HelpText.SetActive(false);
            messageUp = false;
		}
    }
}
