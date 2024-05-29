using UI.MainMenu;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Infrastructure.Manager.Meta
{
	public class MetaManager : MonoBehaviour
	{
		[SerializeField] private MainMenuUI _mainMenuUI;

		private void Start()
		{
			_mainMenuUI.RegisterOfflineGameButtonCallback(StartOfflineGame);
			_mainMenuUI.RegisterExitButtonCallback(ExitGame);
		}


		private void StartOfflineGame()
		{
			SceneManager.LoadScene("3.CoreLocale");
		}

		private void ExitGame()
		{
			Application.Quit();
		}
	}
}