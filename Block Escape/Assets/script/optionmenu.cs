
using UnityEngine;

public class optionmenu : MonoBehaviour
{
  
	public GameObject main;
	public GameObject options;
	public void back()
	{
		options.SetActive(false);
		main.SetActive(true);
	}
	
}
