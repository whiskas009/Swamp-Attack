using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : Weapon
{
    [SerializeField] private float _shootDelay;

    private float _currentTime;

    private void Start()
    {
        _currentTime = _shootDelay;
    }

    public override void Shoot()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.timeScale != 0)
        {
            if (_currentTime >= _shootDelay)
            {
                Instantiate(Bullet, _shootPoint.position, Quaternion.identity);
                _currentTime = 0;
            }
            
            _currentTime += Time.deltaTime;
        }
    }
}
