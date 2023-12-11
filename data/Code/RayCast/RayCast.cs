/* Copyright (C) 2005-2023, UNIGINE. All rights reserved.
*
* This file is a part of the UNIGINE 2 SDK.
*
* Your use and / or redistribution of this software in source and / or
* binary form, with or without modification, is subject to: (i) your
* ongoing acceptance of and compliance with the terms and conditions of
* the UNIGINE License Agreement; and (ii) your inclusion of this notice
* in any version of this software that you use or redistribute.
* A copy of the UNIGINE License Agreement is available by contacting
* UNIGINE. at http://unigine.com/
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unigine;
using Console = System.Console;

[Component(PropertyGuid = "bc2507695fc17ce4804e6580bb78a420f0796574")]
public class RayCast : Component
{
	public CameraCast cameraCast = null;
	private Unigine.Object someObject;
	private Unigine.dvec3 p0, p1;
	
	private void Init()
	{
		Visualizer.Enabled = true;
	}
	
	private void Update()
	{
		someObject = cameraCast.GetObject();
	}

	public Unigine.Object GetObject()
	{
		return someObject;
	}
}