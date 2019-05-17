using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag.Equals ("Enemy"))
			Destroy (other.gameObject);
	}
}
