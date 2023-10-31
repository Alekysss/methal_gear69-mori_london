using UnityEngine;

public class Path : MonoBehaviour 

{
	[SerializeField] Transform[] Points;
	bool movingForward;
	[SerializeField] private float moveSpeed;
	private int pointsIndex;

	void Start()
	{
		transform.position = Points[pointsIndex].transform.position;
	}

	void Update()
	{
		if (pointsIndex >= 0 && pointsIndex < Points.Length)
		{
			transform.position = Vector2.MoveTowards(transform.position, Points[pointsIndex].transform.position, moveSpeed * Time.deltaTime);

			if (transform.position == Points[pointsIndex].transform.position)
			{
				if (pointsIndex == 0)
				{
					movingForward = true; // Start moving forward when reaching the first point.
				}
				else if (pointsIndex == Points.Length - 1)
				{
					movingForward = false; // Start moving backward when reaching the last point.
				}

				if (movingForward)
				{
					pointsIndex++;
				}
				else
				{
					pointsIndex--;
				}

				Debug.Log(pointsIndex);
			}
		}
	}
}
	
	
	

