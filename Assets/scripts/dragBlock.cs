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
		
		float vx = Input.GetAxis ("Mouse X");
		float vy = Input.GetAxis ("Mouse Y");


		if (Mathf.Abs(vx) > Mathf.Abs(vy)) {
			Debug.Log(Mathf.Abs(vx));
			Vector3 mousePoistion = new Vector3 (Input.mousePosition.x, 10, 10);
			Vector3 blockPosition = Camera.main.ScreenToWorldPoint (mousePoistion);
			Debug.Log (blockPosition);
			transform.position = new Vector3(Mathf.Floor(blockPosition.x), transform.position.y, 0.0f);
		}
		else {
			Vector3 mousePoistion = new Vector3 (10, Input.mousePosition.y, 10);
			Vector3 blockPosition = Camera.main.ScreenToWorldPoint (mousePoistion);
			transform.position = new Vector3(transform.position.x, Mathf.Floor(blockPosition.y), 0.0f);
		}
	}
}
