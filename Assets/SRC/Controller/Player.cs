using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Hover_Mechanics))]
public class Player : MonoBehaviour, IGhost
{


    private Debug_Messages debug_messages;
    private Hover_Mechanics hover_mechanics;
    Vector3 player_transform_vector;



    // Start is called before the first frame update
    void Start()
    {
        debug_messages = new Debug_Messages();
        hover_mechanics = GetComponent<Hover_Mechanics>(); 
    }

    // Update is called once per frame
    void Update()
    {
        DoHover();
        DoMovement();
    }


    ///<summary>Do ghost hover with minimum and maximum height.</summary>
    public void DoHover()
    {
        hover_mechanics.Bounce();
    }


    ///<summary>Do player movement. WASD keys.</summary>
    private void DoMovement()
    {
        player_transform_vector = transform.localPosition;  
        //player_transform_vector.y += Input.GetAxis("Jump") * Time.deltaTime * 20;  
        player_transform_vector.x += Input.GetAxis("Horizontal") * Time.deltaTime * 20;  
        player_transform_vector.z += Input.GetAxis("Vertical") * Time.deltaTime * 20;  
        transform.localPosition = player_transform_vector;
    }
}
