using UnityEngine;
using System.Collections;

public class dragBlock : MonoBehaviour {

    private Vector3 dragPosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = dragPosition;
	}

    void OnMouseDrag()
    {
        dragPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        dragPosition = Camera.main.ScreenToWorldPoint(dragPosition);
    }
}
