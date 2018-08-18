using UnityEngine;
using System.Collections;

public class Borders : MonoBehaviour {

	void OnTriggerEnter(Collider other) // підключаєм колайдер  який реагує на всі інші предмети які його касаються
	{
		
		if(other.CompareTag("SnakeMain"))  
		{
				Application.LoadLevel(Application.loadedLevel); // перезапускає лвл  
		}

	}
}
