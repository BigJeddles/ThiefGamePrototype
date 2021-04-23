using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pocket : MonoBehaviour
{
	public GameObject[] randomContentsPefabs;
	public GameObject contents;
	public GameObject[] ManIcons;

    
    public void SetRandomContents()
    {
        // Spawn something random in the pocket
        int rNum = Random.Range(0, randomContentsPefabs.Length);
        GameObject toSpawn = randomContentsPefabs[rNum];
        SetContents(toSpawn);
    }
    
    public void SetContents(GameObject gO)
	{
		// Remove contents
		if (contents)
			Destroy(contents.gameObject);
		// Replace with new contents
		contents = Instantiate(gO, this.transform.position, this.transform.rotation, this.transform);
	}

}
