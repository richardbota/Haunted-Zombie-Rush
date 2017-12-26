using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeGround : MonoBehaviour
{
    [SerializeField] private float objectSpeed = 1;
    [SerializeField] private float resetPosition = 26.53f;
    [SerializeField] private float startPosition = -87.26f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	protected virtual void Update()
	{
	    transform.Translate(Vector3.right * (objectSpeed * Time.deltaTime));

	    if (transform.localPosition.x >= resetPosition)
	    {
	        Vector3 newPos = new Vector3(startPosition, transform.position.y, transform.position.z);
	        transform.position = newPos;
	    }
	}
}
