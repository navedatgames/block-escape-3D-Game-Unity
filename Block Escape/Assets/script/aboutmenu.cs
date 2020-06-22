
using UnityEngine;

public class aboutmenu : MonoBehaviour
{

   	public GameObject main;
	public GameObject about;

    public void back()
	{
		about.SetActive(false);
		main.SetActive(true);
	}
	

}
