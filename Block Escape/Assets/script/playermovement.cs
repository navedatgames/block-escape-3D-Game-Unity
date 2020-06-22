
using UnityEngine;

public class playermovement : MonoBehaviour
{	public Rigidbody rb;
	public float z;
	public GameObject game;
	
	void Start()
	{
		game.SetActive(true);
		Invoke("setinactive",1);
	}
	void setinactive()
	{
		game.SetActive(false);
	}
		
    void Update()
    {
	rb.AddForce(0,0,z);
	
	if(Input.GetKey(KeyCode.D))
	{
	rb.AddForce(z,0,0);
	}
	else if(Input.GetKey(KeyCode.A))
	{
	rb.AddForce(-z,0,0);
	}
	else if(rb.position.y <-1f)
	{
	GetComponent<score>().EndGame();
	}
        
    }
}
