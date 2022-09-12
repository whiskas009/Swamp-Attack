using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;
    [SerializeField] private Collider2D _damageZone;

    private void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        KillEnemies();
        Destroy(gameObject);
    }

    private void KillEnemies()
    {
        RaycastHit2D[] hits = Physics2D.BoxCastAll(transform.position, new Vector2(3, 0.5f), 90, Vector2.left);

        foreach (RaycastHit2D hit in hits)
        {
            if (hit.collider.TryGetComponent(out Enemy enemy))
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
