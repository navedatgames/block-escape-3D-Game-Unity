using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    	public Text scoreText;
	private float scores = 0.0f;
	public GameObject gameover;
	private bool isDead = false;
	public Text endscore;
	private int speed = 2;
	private float highscoreval = 0.0f;
	
   
    void Update()
    {	if(isDead)
	 return;
	
	if(scores>4)
	 speed+=1;
	
	scores+=Time.deltaTime *speed;
	scoreText.text = scores.ToString("0");
	
        
    }
	public void EndGame()
	{	isDead = true;
		gameover.SetActive(true);
		PlayerPrefs.SetFloat("HighScore",scores);
		endscore.text = scores.ToString("0");
		
			
	}
}
		
		
		

