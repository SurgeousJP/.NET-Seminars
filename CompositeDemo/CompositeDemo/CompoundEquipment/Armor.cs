using CompositeDemo.SingleEquipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDemo.CompoundEquipment
{
    internal class Armor : Equipment
    {
        public List<ArmorPiece> ArmorPieces { get; set; } = new();
        public override void Fix()
        {
            foreach (ArmorPiece piece in ArmorPieces)
            {
                piece.Fix();
            }
        }

        public override void WornOut(int _damage)
        {
            foreach (ArmorPiece piece in ArmorPieces)
            {
                piece.WornOut(_damage);
            }
        }
        public void GetPiecesDurability()
        {
            Console.Write("Armor durability: ");
            foreach (ArmorPiece piece in ArmorPieces)
            {
                Console.Write($"{piece.Durability} ");
            }
            Console.WriteLine("");
        }
    }
}
