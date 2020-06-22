using UnityEngine.SceneManagement;
using UnityEngine;

public class startgame : MonoBehaviour
{
    public void loadnextscene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
