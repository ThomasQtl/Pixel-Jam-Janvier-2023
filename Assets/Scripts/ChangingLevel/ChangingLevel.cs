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
        finishLine = 500;   // A adapter en conséquence
	}

    // Update is called once per frame
    void Update()
    {
        if (player.position.x > finishLine)
        {
            // Ben il est arrivé, wahou
            if (SceneManager.GetActiveScene().name == "Niveau1")
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
