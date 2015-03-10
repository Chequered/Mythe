﻿using UnityEngine;
using System.Collections;

public class FishPickup : Interactables
{
    protected float radiusX;
    protected float radiusY;
    protected float x;
    protected float y;
    protected float startScale;
	
    protected Vector2 scale;
    protected Vector2 direction;

	public bool spawnCheck;
    public bool checkMoby;

	protected override void Start()
	{
		base.Start();

		scale = new Vector2(transform.localScale.x, transform.localScale.y);

		startScale = transform.localScale.x;
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();

        if(checkMoby)
        {
            spawnCheck = Camera.main.GetComponent<MobyDickSpawner>().mobyHasSpawned;
        }

		if(spawnCheck == true)
		{
			folowPattern = false;
			MoveAway();
		}
	}

	protected virtual void MoveAway()
	{
		//Debug.Log(this.transform.position.x);

		if(transform.position.x <= 0)
		{
			x = -0.5f;
		}else if(transform.position.x >= 0)
		{
			x = 0.5f;
		}

		direction = new Vector2(x, 0);
		
		transform.position += new Vector3(direction.x, direction.y, 0);
	}


    public int GetPointWorth()
    {
        return points;
	}
}
