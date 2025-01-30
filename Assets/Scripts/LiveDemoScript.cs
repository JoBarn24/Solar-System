using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float yawDegreesPerSecond = 45f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello Unity World!");
    }

    // Update is called once per frame
    void Update()
    {
        //rotate a little bit
        Transform myTransform = GetComponent<Transform>();
        myTransform.Rotate(xAngle: 0f, yAngle: yawDegreesPerSecond * Time.deltaTime, zAngle: 0f);
    }
}
