using Godot;
using System;

public partial class MainMenu : Control
{
	public override void _Ready()
	{
		// 버튼을 찾아서 클릭 이벤트를 연결합니다.
		GetNode<Button>("StartButton").Pressed += OnStartButtonPressed;
		GetNode<Button>("QuitButton").Pressed += OnQuitButtonPressed;
	}

	private void OnStartButtonPressed()
	{
		GD.Print("게임 시작!");
		// 여기에 다음 화면으로 넘어가는 코드를 나중에 추가합니다.
	}

	private void OnQuitButtonPressed()
	{
		GetTree().Quit(); // 프로그램 종료
	}
}
