using UnityEngine;
using System.Collections;

public class Food : MonoBehaviour {
	void OnTriggerEnter(Collider other) // колайдер який дозволяє його касатись ,тіпа щоб стати на нього 
	{
		if(other.CompareTag("SnakeMain")) // якщо голона змія касається 
		{
			other.GetComponent<SnakeMovment>().AddTail(); //добавляєм тіло зміє 
			Destroy(gameObject); //знищуєм об'єкт їжу на яку стала голова 
		}
	}

}
