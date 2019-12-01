using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SignPost : MonoBehaviour
{
    int coinsCollected = 0;
    int coinsTotal = 5;

	public void ResetScene() 
	{
        // Reset the scene when the user clicks the sign post
        SceneManager.LoadScene("Maze");
	}

    public void addCoin(GameObject signPost)
    {
        coinsCollected++;
        signPost.GetComponent<Text>().text = "YOU WIN\nCoins found " + coinsCollected + " / " + coinsTotal;
    }

}