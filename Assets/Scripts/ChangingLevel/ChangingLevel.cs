using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangingLevel : MonoBehaviour
{
    private Rigidbody2D player;
    private int finishLine;

    // Start is called before the first frame update
    void Start()
    {
		player = GetComponent<Rigidbody2D>();
        finishLine = 14;   // A adapter en cons�quence
	}

    // Update is called once per frame
    void Update()
    {
        if (((player.position.x <-86) && (player.position.y > -28) && (player.position.y < -20)) || ((player.position.x <-86) && (player.position.y > -61) && (player.position.y < -54)))
        {
            // Ben il est arriv�, wahou
            if (SceneManager.GetActiveScene().name == "Niveau1")
            {
                SceneManager.LoadScene("Niveau1_1");
                
			}
            else if (SceneManager.GetActiveScene().name == "Niveau1_1")
            {
				SceneManager.LoadScene("Niveau2");
			}
            else if (SceneManager.GetActiveScene().name == "Niveau2")
            {
				SceneManager.LoadScene("Niveau3");
			}
            else
            {
                SceneManager.LoadScene("MenuFin");
            }
        }
    }
}
