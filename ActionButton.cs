using Godot;
using System;

public class ActionButton : Button
{
	public static event Action UseAction;
	public override void _Pressed()
	{
	   UseAction?.Invoke(); 
	}
}
