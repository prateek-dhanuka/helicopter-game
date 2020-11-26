using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowButtonMove : MonoBehaviour
{

	public float speed = 10.0f;
	private Vector2 screenBounds;

	// Start is called before the first frame update
	void Start()
	{
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
	}

	// Update is called once per frame
	void Update()
	{
		float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;

		transform.Translate(new Vector3(x, y, 0), Space.World);
	}
}
