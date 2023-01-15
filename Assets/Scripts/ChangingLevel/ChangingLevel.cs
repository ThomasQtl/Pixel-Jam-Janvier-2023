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
            // Ben il est arriv�, wahou
            if ((SceneManager.GetActiveScene().name == "Niveau1") && (((player.position.x <-86) && (player.position.y > -28) && (player.position.y < -20)) || ((player.position.x <-86) && (player.position.y > -61) && (player.position.y < -54))))
            {
                SceneManager.LoadScene("Niveau1_2");
			}
            else if ((SceneManager.GetActiveScene().name == "Niveau1_2") && (((player.position.x < -64) && (player.position.y > -28) && (player.position.y < -20)) || ((player.position.x <-64) && (player.position.y > -61) && (player.position.y < -54))))
            {
				SceneManager.LoadScene("Niveau2");
			}
            else if ((SceneManager.GetActiveScene().name == "Niveau2") && (((player.position.x < -88) && (player.position.y > -28) && (player.position.y < -20)) || ((player.position.x <-88) && (player.position.y > -61) && (player.position.y < -54))))
            {
				SceneManager.LoadScene("Niveau2_2");
			}
            else if (false)
            {
                SceneManager.LoadScene("MenuFin");
            }
    }
}
