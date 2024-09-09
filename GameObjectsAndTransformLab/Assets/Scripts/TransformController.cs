using UnityEngine;

public class TransformController : MonoBehaviour
{
    private void Update()
    {
        // move the target GameObject
        var x = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(0, x, 0);
        
        //rotate the target game object
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
        
    }
}