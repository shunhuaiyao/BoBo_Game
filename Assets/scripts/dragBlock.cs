using UnityEngine;
using System.Collections;

public class DragBlock : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDrag(){
		Vector3 mousePoistion = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10);
		Vector3 blockPosition = Camera.main.ScreenToWorldPoint (mousePoistion);
		transform.position = new Vector3(blockPosition.x, blockPosition.y, 0.0f);

	}
}
