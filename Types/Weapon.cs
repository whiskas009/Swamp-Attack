using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private int _price;
    [SerializeField] private Sprite _icon;
    [SerializeField] protected Bullet Bullet;
    [SerializeField] protected Rocket Rocket;
    [SerializeField] protected Transform _shootPoint;

    public string Name => _name;
    public int Price => _price;
    public Sprite Icon => _icon;

    private void Update()
    {
        Shoot();
    }

    public abstract void Shoot();
}
