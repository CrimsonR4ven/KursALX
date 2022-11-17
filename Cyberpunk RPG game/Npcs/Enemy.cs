using Cyberpunk_RPG_game.Items;

namespace Cyberpunk_RPG_game.Npcs
{
    public class Enemy
    {
        public string Name;
        int HP, Heal;
        Weapon EquippedWeapon;
        WeaponMelee Melee;
        EnumEnemy EnemyType;

        public void HPLoss(int loss)
        {
            HP = HP - loss;
        }
        public void HPGain()
        {
            HP = HP + Heal;
        }

    }
}
