using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public static bool HasPassport;
	public static bool HasWrongPassport;
	public GameObject passportIcon;
	public GameObject WrongpassportIcon;
	private void Update()
	{
		LookForPassport();
		if (HasPassport == true)
		{
			ReturnWithPassport();
		}
		if (HasWrongPassport == true)
		{
			WrongPassport();
		}
	}

	void LookForPassport()
	{
		// Raycast
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		// cast a ray, check name for "Passport"
		if (Physics.Raycast(ray, out hit, 2))
		{
			Debug.LogFormat("{0} was hit", hit.collider.name);
			Debug.DrawLine(ray.origin, hit.point, Color.blue);
			if (hit.collider.name.Contains("Passport"))
			{
				if (Input.GetKeyDown(KeyCode.E))
				{
					HasPassport = true;
				}
				Debug.DrawLine(ray.origin, hit.point, Color.green);
				Debug.Log("Passport spotted");
			}
			if (Physics.Raycast(ray, out hit, 2))
			{
				Debug.LogFormat("{0} was hit", hit.collider.name);
				Debug.DrawLine(ray.origin, hit.point, Color.blue);
				if (hit.collider.name.Contains("object1") || (hit.collider.name.Contains("object2") || (hit.collider.name.Contains("object3"))))
				{
					Debug.Log("Getting the object");
					if (Input.GetKeyDown(KeyCode.E))
					{
						HasWrongPassport = true;
					}
					Debug.DrawLine(ray.origin, hit.point, Color.green);
					Debug.Log("WrongObject spotted");
				}
			}

			else
				Debug.DrawRay(ray.origin, ray.direction * 2, Color.red);
		}
	}

	void ReturnWithPassport()
	{
		passportIcon.SetActive(true);
	}
	void WrongPassport()
	{
		WrongpassportIcon.SetActive(true);
	}
}
