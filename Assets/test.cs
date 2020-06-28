using UnityEngine;

public class test : MonoBehaviour
{
	private void Update()
	{
		// コントローラーのキーマッピングを調べるためのコード
		for (var keyCode = KeyCode.JoystickButton0; keyCode <= KeyCode.JoystickButton19; ++keyCode)
		{
			if (Input.GetKeyDown(keyCode))
			{
				Debug.Log($"{keyCode}が反応しました。");
			}
		}
	}
}