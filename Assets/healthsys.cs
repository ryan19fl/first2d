
public class healthsys 
{
    private int health;
   public healthsys(int health)
    {
        this.health = health;
    }
    public int Gethealth()
    {
        return health;
    }
    public void damage(int damageamount)
    {
        health -= damageamount;
    }
    public void heal(int healamount)
    {
        health += healamount;
    }
}
