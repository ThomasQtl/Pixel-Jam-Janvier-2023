using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangingLevel : MonoBehaviour
{
    public bool IsArrived { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        IsArrived = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsArrived)
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

			IsArrived = false;
		}
    }
}
