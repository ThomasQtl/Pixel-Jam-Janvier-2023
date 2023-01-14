using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingTImeline : MonoBehaviour
{
    private Rigidbody2D player;

	public bool IsTimeTraveling { get; set; }   // Pour savoir si on est dans le présent ou le passsé

    // Start is called before the first frame update
    void Start()
    {
        IsTimeTraveling = false;
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4)) && IsTimeTraveling == false)
        {
            float posY = 100;   // A modifier en conséquence

            player.position.Set(player.position.x, posY);
        }
        else if ((Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4)) && IsTimeTraveling == true) { }
        {
			float posY = 0;     // A modifier en conséquence

			player.position.Set(player.position.x, posY);
		}
    }
}
