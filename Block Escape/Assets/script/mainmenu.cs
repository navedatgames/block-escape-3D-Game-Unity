using UnityEngine.SceneManagement;
using UnityEngine;

public class mainmenu : MonoBehaviour
{
	public GameObject options;
	public GameObject main;
    	public void play()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
	public void option()
	{
		main.SetActive(false);
		options.SetActive(true);
	}
	
	public void quit()
	{
		Application.Quit();
	}
}
