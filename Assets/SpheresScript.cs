using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpheresScript : MonoBehaviour
{
	public GameObject Sphere;
	public Canvas Canvas;
	public Button Button;
	public List<Color> colorList = new List<Color>();
	public int count;


	void Start()
    {
		count = 0;

		Sphere.transform.position = new Vector3(0f, 0f, 0f);
		Canvas.transform.position = new Vector3(0f, 0f, 20f);

		colorList.Add(Color.yellow);
		colorList.Add(Color.red);
		colorList.Add(Color.blue);
		colorList.Add(Color.black);
		colorList.Add(Color.green);
    }

    
    void Update()
    {
		
    }

	public void Method1()
	{
		int counter = Method2();
		Sphere.transform.GetComponent<Renderer>().material.color  = colorList[counter];
	}

	public int Method2()
	{
		int counter = count;
		count = count + 1;
		counter = count;
		return counter;
	}
}
