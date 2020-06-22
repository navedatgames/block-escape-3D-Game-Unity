using UnityEngine.SceneManagement;
using UnityEngine;

public class playercollision : MonoBehaviour
{	public playermovement move;
	void OnCollisionEnter(Collision info)
	{
		if(info.collider.tag=="obstacle")
		{
			move.enabled = false;
			GetComponent<score>().EndGame();
		}
	}
}
