using Godot;
using System;

public class BattleManager : Control
{
	[Export]
	NodePath ActionContainerPath;
	ActionContainer ActionContainer;

	[Export]
	NodePath ActionPanelPath;
	Panel ActionPanel;

	Random random = new Random();

	public override void _Ready()
	{
		ActionContainer = GetNode<ActionContainer>(ActionContainerPath);
		ActionPanel = GetNode<Panel>(ActionPanelPath);

		StartTurn();
	}

	bool CoinFlip()
	{
		int number = random.Next(0, 100);
		return number <= 50;
	}

	void StartTurn()
	{
		if (CoinFlip())
		{
			GD.Print("It's the player's turn.");
			ActionPanel.Visible = true;
			ActionButton.UseAction += () => Attack();
			ActionContainer.SetActionText("Tornado Slam");
		}
		else
		{
			GD.Print("It's the enemy's turn.");
			ActionButton.UseAction -= () => Attack();
			ActionPanel.Visible = false;

			StartTurn();
		}
	}

	void Attack()
	{
		GD.Print("Yay! You slaughtered it!");
		StartTurn();
	}

}
