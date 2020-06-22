
using UnityEngine;

public class Mainmenus : MonoBehaviour
{
   public GameObject main;
	public GameObject option;
	public GameObject about;

    public void options()
	{
		main.SetActive(false);
		option.SetActive(true);
	}
	public void abouts()
	{
	main.SetActive(false);
		about.SetActive(true);
	}
	public void quit()
	{
		Application.Quit();
	}
	
	
}
