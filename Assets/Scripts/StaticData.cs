using UnityEngine;

public class StaticData

// Script written by Brandon Foshe

/* <summary>
 * 
 * Contains the static data for checking if parts are collected across scripts
 */
{
	public static bool[] parts = new bool[4];


	// Takes in a part num then sets that part to true when collected
	public static void Collect(int partNum)
	{
		parts[partNum - 1] = true;
	}


	// Loops through all parts to see if they're all collected
	public static bool CheckAll()
	{
		foreach (bool partStatus in parts)
		{
			// If there is a part not collected, return false
			if (!partStatus)
			{
				return false;
			}
		}
		// Otherwise all parts are collected return true
		return true;
	}
}
