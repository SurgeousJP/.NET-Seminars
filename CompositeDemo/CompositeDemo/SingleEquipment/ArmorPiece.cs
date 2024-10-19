namespace CompositeDemo.SingleEquipment
{
    enum Material
    {
        Leather,
        Iron,
        Gold,
        Diamond,
    }
    internal class ArmorPiece :Equipment
    {
        private int MaxDurability { get; set; }
        protected Material Type { get; set; }
        public ArmorPiece(Material _type)
        {
            this.Type = _type;
            switch (Type)
            {
                case Material.Leather:
                    this.Durability = 30;
                    break;
                case Material.Iron:
                    this.Durability = 50;
                    break;
                case Material.Gold:
                    this.Durability = 70;
                    break;
                case Material.Diamond:
                    this.Durability = 100;
                    break;
            }
            this.MaxDurability = this.Durability;
        }
        public override void Fix()
        {
            this.Durability += 5;
            if (this.Durability > this.MaxDurability)
            {
                this.Durability = this.MaxDurability;
            }
        }

        public override void WornOut(int _damage)
        {
            this.Durability -= _damage;
            if (this.Durability < 0)
            {
                this.Durability = 0;
            }
        }
    }
}
