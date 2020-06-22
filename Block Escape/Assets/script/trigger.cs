using UnityEngine;

public class trigger : MonoBehaviour
{	public GameManager game;
	void OnTriggerEnter()
	{
		FindObjectOfType<GameManager>().completed();
	}

	
    

}
