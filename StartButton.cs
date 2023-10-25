using Godot;
using System;

public class StartButton : Button
{
	public override void _Pressed()
	{
		SceneManager.Instance.SwitchScene(1);
	}
}
