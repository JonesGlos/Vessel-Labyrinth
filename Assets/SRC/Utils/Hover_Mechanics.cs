using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover_Mechanics : MonoBehaviour
{
    [SerializeField] private float bounceRate = 0.3f;
    [SerializeField] private float speed;
    private float defaultPosY = 0;
    private float timer = 0;



    // Start is called before the first frame update
    void Start()
    {
        defaultPosY = transform.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //<summary>Bounce entity by bounceRate and speed.</summary>
    public void Bounce()
    {
        timer += Time.deltaTime * speed;
        transform.localPosition = new Vector3(transform.localPosition.x, defaultPosY + Mathf.Sin(timer) * bounceRate, transform.localPosition.z);
    }
}
