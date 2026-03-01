using System.Linq;
using UnityEngine;

public class SurrenderBox : MonoBehaviour

// Script written by Brandon Foshe

/* <summary>
 * 
 * While hovering over surrender box && click -
 * Collect all parts
 */

{

	// When surrender is clicked, check all part statuses
	// If you reach one that is false, collect it, then continue on

	int i = 1;
	public void OnClick()
	{
		foreach (bool partStatus in StaticData.parts)
		{
			if (!partStatus)
			{
				StaticData.Collect(i);
			}
			i++;
		}
	}
}
