using EduPlans.Db.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Сontexts.Reference
{
    public class BlockContext:DbContext
    {
        public DbSet<Block> Blocks { get; set; }

        public BlockContext() : base("EduPlansDb"){ }

        public void Add(Block block)
        {
            Blocks.Add(block);
        }

        public Block GetBlock(int id)
        {
            return Blocks.FirstOrDefault(x => x.Id == id);
        }
    }
}
