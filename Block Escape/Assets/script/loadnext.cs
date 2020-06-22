using UnityEngine;
using UnityEngine.SceneManagement;

public class loadnext : MonoBehaviour
{

	public void loadlevel()
	{
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
}
