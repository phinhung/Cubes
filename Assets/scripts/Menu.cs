using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	public string level;	



	public void StartGame()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void LoadLevel1()
	{
		
		SceneManager.LoadScene (2);
	}

	public void LoadLevel2()
	{

		SceneManager.LoadScene (3);
	}

	public void LoadLevel3()
	{

		SceneManager.LoadScene (4);
	}
}
