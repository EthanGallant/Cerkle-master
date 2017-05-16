using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashScreen : MonoBehaviour
{
	public Image Title;
	public string MainMenu;

	IEnumerator Start()
	{
		Title.canvasRenderer.SetAlpha (0.0f);

		FadeIn();
		yield return new WaitForSeconds(2.5f);
		FadeOut();
		yield return new WaitForSeconds(2.5f);
		SceneManager.LoadScene(MainMenu);
	}

	void FadeIn()
	{
		Title.CrossFadeAlpha (1.0f, 1.5f, false);
	}

	void FadeOut()
	{
		Title.CrossFadeAlpha (0.0f, 2.5f, false);
	}
}

