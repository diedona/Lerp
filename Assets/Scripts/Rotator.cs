using UnityEngine;

public class Rotator : MonoBehaviour
{

    public Transform objectToRotate;

    // Use this for initialization
    void Start()
    {
        this.objectToRotate = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        this.objectToRotate.transform.Rotate(new Vector3(10, 3, 15) * Time.deltaTime);
    }
}
