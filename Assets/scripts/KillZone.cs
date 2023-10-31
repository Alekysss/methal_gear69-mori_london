using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
	public GameObject respawnPoint;
	public GameObject player;
	
	void Start()
	{}

	void Update()
	{}


	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			player.transform.position = respawnPoint.transform.position;
		}
	}
}