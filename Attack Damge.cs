public class Attack_Damage : MonoBehaviour
{
    public float lifetime,AttackDamage;
    
    void Start()
    {
        Destroy(gameObject,lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}