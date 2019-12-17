using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 5;
    public ParticleSystem explosionParticle;
    public float hp = 10f;

    public void TakeDamage(float damage)
    {
        hp -= damage;

        if(hp <= 0)
        {
            ParticleSystem instance = Instantiate(explosionParticle,this.transform.position,this.transform.rotation);
            Destroy(instance.gameObject, instance.main.duration);
        }
    }
}
