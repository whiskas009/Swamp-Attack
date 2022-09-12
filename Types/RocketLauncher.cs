using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : Weapon
{
    [SerializeField] private float _shootDelay;

    private float _currentTime;

    private void Start()
    {
        _currentTime = _shootDelay;
    }

    public override void Shoot()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0) && Time.timeScale != 0 && _currentTime >= _shootDelay)
        {
            Instantiate(Rocket, _shootPoint.position, Rocket.transform.rotation);
            _currentTime = 0; 
        }

        if(_currentTime < _shootDelay)
            _currentTime += Time.deltaTime;
    }
}
