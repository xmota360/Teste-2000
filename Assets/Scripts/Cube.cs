using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour 
{
	public float lerpFactor = 0f;
	public float startPositionX = 0f;
	public float endPositionX = 5f;

	private Vector3 currentPosition = new Vector3 ();
	private float destination = 5f;


	void Start () 
	{
	}

	void Update () 
	{
		lerpFactor += Time.deltaTime;

		if (transform.position.x != destination) 
		{
			currentPosition.x = Mathf.Lerp (currentPosition.x, destination, lerpFactor);
			transform.position = currentPosition;
		} 
		else 
		{
			if (transform.position.x == startPositionX)
				destination = endPositionX;
			else
				destination = startPositionX;

			lerpFactor = 0f;
		}
	}
}