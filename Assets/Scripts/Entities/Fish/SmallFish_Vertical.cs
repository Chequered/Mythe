﻿using UnityEngine;
using System.Collections;

public class SmallFish_Vertical : FishPickup 
{

	private bool _negativeMovement;
	
	protected override void Start() 
	{
		base.Start();
		
		mass = 10;

		radiusX = transform.position.x;

		radiusY = transform.position.y +3;
		
		x = transform.position.x;
		y = transform.position.y;
		
		_negativeMovement = false;
	}
	
	protected override void FixedUpdate () 
	{
		base.FixedUpdate();
	}
	
	protected override void Movement()
	{
		direction = new Vector2 (x, y);
		
		if(transform.position.y >= radiusY)
		{
			_negativeMovement = true;
		}else if(transform.position.y <= -radiusY)
		{
			_negativeMovement = false;
		}
		if(_negativeMovement)
		{
			scale.x = startScale;
			y -= speed;
		}else if(!_negativeMovement)
		{
			scale.x = -startScale;
			y += speed;
		}

//		_bounce = (Mathf.Sin(mathSpeed * 25)) * radiusY;

		transform.position = direction;

		transform.localScale = scale;
	}
}
