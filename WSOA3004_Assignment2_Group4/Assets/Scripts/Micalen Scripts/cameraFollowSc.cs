using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowSc : MonoBehaviour
{
    public GameObject PlayerFollow;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float interpolation = speed * Time.deltaTime;

        Vector3 pos = this.transform.position;
        pos.y = Mathf.Lerp(this.transform.position.y, PlayerFollow.transform.position.y, interpolation);
        pos.x = Mathf.Lerp(this.transform.position.x, PlayerFollow.transform.position.x, interpolation);

        this.transform.position = pos;
    }
}
