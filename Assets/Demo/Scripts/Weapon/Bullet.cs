using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
   
    public GameObject Explosion;

    [SerializeField]
    private BulletInfo _bulletInfo;

    private Rigidbody _rigid;
    // Start is called before the first frame update
    void Start()
    {
        _rigid = GetComponent<Rigidbody>();
        
    }

    private void OnCollisionEnter(Collision col)
    {
        GameObject particleOBJ = Instantiate(_bulletInfo.Explosion) as GameObject;
        particleOBJ.transform.position = transform.position;
        Destroy(particleOBJ, 1f);
        int colLayer = col.gameObject.layer;
        if(colLayer == LayerMask.NameToLayer("Enemy"))
        {
            
        }
        Destroy(gameObject);
    }
}