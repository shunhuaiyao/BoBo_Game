using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
		transform.position = new Vector3(transform.position.x, transform.position.y, 0);

    }
}
