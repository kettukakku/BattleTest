using Godot;
using System;

public class SceneManager : Node
{
	[Export]
	PackedScene MainMenu;
	[Export]
	PackedScene BattleScene;

	public static SceneManager Instance;

	public override void _Ready()
	{
		if (Instance == null)
		{
			Instance = this;
		}
		else
		{
			QueueFree();
		}      
		GetTree().ChangeScene(MainMenu.ResourcePath);
	}

	public void SwitchScene(int index)
	{
		switch (index)
		{
			case 0:
			GetTree().ChangeScene(MainMenu.ResourcePath);
			break;
			case 1:
			GetTree().ChangeScene(BattleScene.ResourcePath);
			break;
		}
	}
}
