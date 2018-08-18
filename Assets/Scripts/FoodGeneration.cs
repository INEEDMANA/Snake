using UnityEngine;
using System.Collections;

public class FoodGeneration : MonoBehaviour {

	public float XSize = 8.8f; // значення для задання рандома 
    public float ZSize = 8.8f; // значення для задання рандома 
	public GameObject foodPrefab; // сама їда
	public Vector3 curPos; // текуща позиція 
	public GameObject curFood;  // текуща їда впринципі той самий префаб ну з сurPos
	void AddNewFood()
	{
	RandomPos();
	curFood = GameObject.Instantiate(foodPrefab,curPos,Quaternion.identity) as GameObject; // інстантіюєм текущу їжу в рандомній позиції 
	}
	void RandomPos()
	{
    curPos = new Vector3(Random.Range(XSize*-1,XSize),0.25f,Random.Range(ZSize*-1,ZSize)); // рандомна позиція  (піддивився в туторалкі ) 
	}

	void Update()
	{
		if(!curFood)  
		{
			AddNewFood();
		}
		else
		{
			return;
		}
	}
}
