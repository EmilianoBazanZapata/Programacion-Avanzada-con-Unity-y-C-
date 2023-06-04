namespace MasterClass.Assets.Scenes.Scripts.Patrones.Strategy
{
    public interface IWeapon
    {
        void Attack();
    }

    public interface IDamage
    {
        void DoDamage(int damage);
    }
}