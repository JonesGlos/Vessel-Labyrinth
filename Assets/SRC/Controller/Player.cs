using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IGhost
{


    private Debug_Messages debug_messages;
    Vector3 player_transform_vector;



    // Start is called before the first frame update
    void Start()
    {
        debug_messages = new Debug_Messages();
        DoHover();   
    }

    // Update is called once per frame
    void Update()
    {
        DoMovement();
    }


    ///<summary>Do ghost hover with minimum and maximum height.</summary>
    public void DoHover()
    {
        Debug.Log(debug_messages.Pass());
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
