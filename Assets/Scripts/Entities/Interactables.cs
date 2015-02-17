﻿using UnityEngine;
using System.Collections;

public class Interactables : MonoBehaviour 
{
	protected bool hasBeenHooked;

	protected float speed;
	protected float mathSpeed;

	[SerializeField]
	protected PickupType type;

	[SerializeField]
	protected PickupType secondaryType;

	[SerializeField]
	protected float mass;
	
	[SerializeField]
	protected string objectName;

	[SerializeField]
	protected int points;

	[SerializeField]
	protected int secondaryPoints;

	[SerializeField]
	protected float speedMultiplier;

	// Use this for initialization
	protected virtual void Start () 
	{
		hasBeenHooked = false;
	}

    public int GetPoints()
    {
        return points;
    }
	protected virtual void FixedUpdate()
	{
		speed = speedMultiplier;
		mathSpeed += Time.deltaTime * speedMultiplier;
		
		if(!hasBeenHooked)
		{
			Movement();
		}
	}
	
	protected virtual void Movement()
	{
		
	}
<<<<<<< HEAD

    public void PickUp(Transform newParent)
    {
        transform.parent = newParent;
        hasBeenHooked = true;
    }
=======
>>>>>>> 41cbbe2e7efc9cbd46cbaa8315f0a62c305073d3
}


public enum PickupType
{
	none,
	fish,
	gold,
	trap
}
