using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Games.GlobeDefine;
using System;

public class Obj_ZhaLan : Obj_Mono
{
	public static Obj_ZhaLan instance = null;
	public static Obj_ZhaLan GetInstance()
	{
		return instance;
	}
	void Start()
	{
		instance = this;
	}
	public void playdeath()
	{
		Destroy();
	}
	void Destroy()
	{
		GameObject.DestroyImmediate(this.gameObject);
	}
}
