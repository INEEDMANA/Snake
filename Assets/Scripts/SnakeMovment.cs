using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class SnakeMovment : MonoBehaviour {

	public float Speed;
	public float RotationSpeed;
	public List<GameObject> tailObjects = new List<GameObject>();
	public float z_offset = 0.5f;

	public GameObject TailPrefab;
	public Text ScoreText;
	public int score = 0;
	void Start () {
	tailObjects.Add(gameObject); // добавляєм об'єкт (хвіст до голови)
	}
	void Update () 
	{
	ScoreText.text = score.ToString(); // вивод рахунку 
		transform.Translate(Vector3.forward*Speed*Time.deltaTime); // кнопки управління знизу 

		if(Input.GetKey(KeyCode.D))
		{
			transform.Rotate(Vector3.up*RotationSpeed*Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.A))
		{
			transform.Rotate(Vector3.up*-1*RotationSpeed*Time.deltaTime);
		}
	}

	public void AddTail()
	{
		score++; // добавляєм +1 до рахунку при кожному новому добавленні тіла 
		Vector3 newTailPos = tailObjects[tailObjects.Count-1].transform.position; // створюєм новий об'єкт з новою позицією яка на -1 менша від голови
		newTailPos.z -= z_offset; 
		tailObjects.Add(GameObject.Instantiate(TailPrefab,newTailPos,Quaternion.identity) as GameObject);
	}
}
