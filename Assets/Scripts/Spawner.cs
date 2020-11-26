using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject[] Prefabs;
	public float minRespawnTime, maxRespawnTime;
	public float minSpeed, maxSpeed;
    public float z;
	private Vector2 screenBounds;

	// Start is called before the first frame update
	void Start()
	{
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

		StartCoroutine(cloudWave());
	}

	private void spawn()
	{
		int PrefabIndex = Mathf.FloorToInt(Random.value * Prefabs.Length);

		GameObject a = Instantiate(Prefabs[PrefabIndex]) as GameObject;

		a.transform.position = new Vector3(screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y), z);

		a.GetComponent<Rigidbody2D>().velocity = new Vector2(-random(minSpeed, maxSpeed), 0);
	}

	IEnumerator cloudWave()
	{
		while (true)
		{
			yield return new WaitForSeconds(random(minRespawnTime, maxRespawnTime));
			spawn();
		}
	}

	float random(float min, float max)
	{
		return Random.value * (max - min) + min;
	}

	// Update is called once per frame
	void Update()
	{

	}
}
