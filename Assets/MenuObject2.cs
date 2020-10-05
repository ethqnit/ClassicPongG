using UnityEngine;
using System.Collections;

public class MenuObject2 : MonoBehaviour {

		public bool isQuit = false;

		void OnMouseEnter()
		{
			GetComponent<Renderer>().material.color = Color.red;
		}
		void OnMouseExit()
		{
		GetComponent<Renderer>().material.color = Color.white;
		}
		void OnMouseDown()
		{
			if(isQuit)
			{
			Application.Quit();
			}
			else
			{
			Application.LoadLevel(0);
			}
		}
}
	