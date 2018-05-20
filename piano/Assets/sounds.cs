using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sounds : MonoBehaviour {

	GameObject[] allObjects;
	bool[] clicked;
	bool c1b;

	// Use this for initialization
	void Start () {

		c1b = false;

		for (int i = 0; i < allObjects.Length; i++) {
			if (allObjects [i].name.Equals ("B2"))
				print (i);
		}

		Button c1 = allObjects[51].GetComponent<Button>();
		print ("start " + allObjects [0].activeInHierarchy);

	    
		StartCoroutine (toggleColor (c1, Color.red , 0));
		ColorBlock cb = c1.colors;
		cb.normalColor = Color.magenta;
		c1.colors = cb;


	}



	void Awake(){

		allObjects = UnityEngine.Object.FindObjectsOfType<GameObj 

	public void c1Clicked(){
        
		Awake();
		//print ("c1Clicked " + allObjects [0].activeInHierarchy);
		clicked[0] = true;
		c1b = true;
		Button l = allObjects[37].GetComponent<Button>();
		//StartCoroutine(toggleOnce(l, Color.blue));


		ColorBlock cb = l.colors;
		cb.normalColor = Color.magenta;
		l.colors = cb;


		l = allObjects[49].GetComponent<Button>();

		cb = l.colors;
		cb.normalColor = Color.red;
		l.colors = cb;

		//cb.normalColor = Color.white;
		//l.colors = cb;

	}

	public void b2Clicked(){

		Awake();
		//print ("c1Clicked " + allObjects [0].activeInHierarchy);
		clicked[0] = true;
		c1b = true;
		Button l = allObjects[37].GetComponent<Button>();
		//StartCoroutine(toggleOnce(l, Color.blue));


		ColorBlock cb = l.colors;
		cb.normalColor = Color.white;
		l.colors = cb;

		l = allObjects[51].GetComponent<Button>();
		//StartCoroutine(toggleOnce(l, Color.blue));


		cb = l.colors;
		cb.normalColor = Color.white;
		l.colors = cb;


		l = allObjects[49].GetComponent<Button>();
		//StartCoroutine(toggleOnce(l, Color.blue));


		cb = l.colors;
		cb.normalColor = Color.red;
		l.colors = cb;
		//cb.normalColor = Color.white;
		//l.colors = cb;

	}
	IEnumerator wait(){
		yield return new WaitForSeconds (1);
	}

	IEnumerator toggleColor( Button b, Color c, int i){

		Awake ();

		while (/*!clicked[i]*/ !c1b) {

			yield return new WaitForSeconds (1);

			ColorBlock cb = b.colors;
			cb.normalColor = c;
			b.colors = cb;

			yield return new WaitForSeconds (1);

			cb.normalColor = Color.white;
			b.colors = cb;
		}

		print ("Done");
	}


		IEnumerator toggleOnce( Button l , Color c){

				ColorBlock cb = l.colors;
				cb.normalColor = c;
				l.colors = cb;

		yield return new WaitForSeconds (1);

		cb.normalColor = Color.white;
		l.colors = cb;
			}
	
	// Update is called once per frame
	void Update () {

		// print (c1b);
		if ( c1b ) {
			Button b2 = allObjects [49].GetComponent<Button> ();
			StartCoroutine (toggleColor (b2, Color.red, 1));
		}
	}
}
