﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameCon : MonoBehaviour {

	public GameObject puzzle;
	public bool isCorrect;

	public GameObject currPuzzle;

	// Use this for initialization
	void Start () {
		
	}

	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "puzzle") currPuzzle = collision.gameObject;
	}

	private void OnTriggerStay2D(Collider2D collision)
	{
		if (collision.tag == "puzzle") currPuzzle = collision.gameObject;
	}

	

	void FixedUpdate()
	{
		if (currPuzzle == puzzle)
		{
			isCorrect = true;
		}
		else isCorrect = false;

		//Debug.Log("End game: " + this.name);
		this.GetComponent<BoxCollider2D>().enabled = false;
		this.GetComponent<CapsuleCollider2D>().enabled = false;
		this.GetComponent<BoxCollider2D>().enabled = true;
		this.GetComponent<CapsuleCollider2D>().enabled = true;
	}

	// Update is called once per frame
	void Update () {
		if (currPuzzle == puzzle)
		{
			isCorrect = true;
		}
		else isCorrect = false;
	}

	void LateUpdate()
	{
		if (currPuzzle == puzzle)
		{
			isCorrect = true;
		}
		else isCorrect = false;
	}
}
