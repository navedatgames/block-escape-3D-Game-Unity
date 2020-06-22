using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{	public float sec = 1f;
	public bool gamehasended = false;
	public GameObject complete;
	
	public void completed()
	{
	complete.SetActive(true);
	}
	
	
}
