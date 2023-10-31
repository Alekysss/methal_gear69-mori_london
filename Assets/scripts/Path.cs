using UnityEngine;

public class Path : MonoBehaviour 

{
	[SerializeField] Transform[] Points;

	[SerializeField] private float moveSpeed;

	private int pointsIndex;

	void Start()
	{
		transform.position = Points[pointsIndex].transform.position;
	}

	void Update()
	{
		if(pointsIndex <= Points.Length -1)
		{
			transform.position = Vector2.MoveTowards(transform.position, Points[pointsIndex].transform.position, moveSpeed * Time.deltaTime);

			if(transform.position == Points[pointsIndex].transform.position)
			{
				pointsIndex =+ 1;
			}

			if(pointsIndex == Points.Length)
			{
				pointsIndex = 0;
			}

		}
	}
}