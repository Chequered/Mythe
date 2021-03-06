﻿using UnityEngine;
using System.Collections;

public class SmallFishVertical : FishPickup 
{

	private bool _negativeMovement;
	
	protected override void Start() 
	{
		base.Start();

		speedMultiplier = 0.085f;

		radiusY = 9;
		_negativeMovement = false;
	}
	
	protected override void FixedUpdate () 
	{
		base.FixedUpdate();
	}
	
	protected override void Movement()
	{
		direction = new Vector2 (x, y);

		if(y >= radiusY)
		{
			_negativeMovement = true;
		}else if(y <= -radiusY)
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
		
		transform.position = basePosition + direction;

		transform.localScale = scale;
	}
}
