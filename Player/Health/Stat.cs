﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat 
{
	[SerializeField] private Healthbar bar;
	[SerializeField] private float maxVal;
	[SerializeField] private float currentVal;

	public float CurrentVal
	{
		get 
		{
			return currentVal;
		}
		set 
		{
			this.currentVal = Mathf.Clamp(value,0,MaxVal);
			bar.Value = currentVal;
		}
	}

	public float MaxVal
	{
		get 
		{ 
			return maxVal;
		}
		set 
		{
			this.maxVal = value;
			bar.MaxValue = (int)maxVal;
		}
	}

	public void Initialize()
	{
		this.MaxVal = maxVal;
		this.CurrentVal = currentVal;
	}
}