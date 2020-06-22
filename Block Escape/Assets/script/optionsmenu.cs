using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionsmenu : MonoBehaviour
{

   	public GameObject main;
	public GameObject option;

    public void back()
	{
		option.SetActive(false);
		main.SetActive(true);
	}
	
}