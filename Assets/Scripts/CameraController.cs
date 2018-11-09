using System;
using System.Linq;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float _speed;
    public Transform[] _views;

    private Transform currentView;
    private int currentViewNum;

    // Use this for initialization
    void Start()
    {
        this.startView();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            this.nextView();
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.moveCamera();
    }

    /// //////////////////////////

    private void nextView()
    {
        this.currentViewNum++;
        if(this.currentViewNum >= _views.Count())
        {
            this.currentViewNum = 0;
        }

        this.goToView();
    }

    private void startView()
    {
        this.currentViewNum = 0;
        this.goToView();
    }

    private void goToView()
    {
        this.currentView = _views[this.currentViewNum];
    }

    private void moveCamera()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, this.currentView.position, Time.deltaTime * _speed);
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, this.currentView.rotation, Time.deltaTime * _speed);
    }
}
