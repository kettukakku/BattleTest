using Godot;
using System;
using System.Collections.Generic;

public class ActionContainer : VBoxContainer
{
	List<Button> actionButtons = new List<Button>();
	
	public override void _Ready()
	{
		foreach (Button button in GetChildren())
		{
			actionButtons.Add(button);
		}
	}

	public void SetActionText(string text) => actionButtons[0].Text = text;
}
