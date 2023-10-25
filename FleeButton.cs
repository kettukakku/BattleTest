using Godot;
using System;

public class FleeButton : Button
{
	public override void _Pressed()
	{
		SceneManager.Instance.SwitchScene(0);
	}
}
