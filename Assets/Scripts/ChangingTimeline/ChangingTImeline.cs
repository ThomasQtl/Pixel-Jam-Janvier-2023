using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingTImeline : MonoBehaviour
{
    private Rigidbody2D player;

	public bool IsTimeTraveling { get; set; }   // Pour savoir si on est dans le pr�sent ou le passs�

    // Start is called before the first frame update
    void Start()
    {
        IsTimeTraveling = false;
        player = GetComponent<Rigidbody2D>();
        player.position = new Vector3(player.position.x, -2f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad4) && !IsTimeTraveling)
        {
            print("Dedans");
            IsTimeTraveling = true;
            player.position = new Vector3(player.position.x, -20.3f, 0f);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4) && IsTimeTraveling)
        {
            IsTimeTraveling = false;
            player.position = new Vector3(player.position.x, -2f, 0f);
		}
    }
}
