using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllComands()
        {
            var commands = new List<Command>
            {
                new Command(0, "Boil an egg", "Boil water", "Pan"),
                new Command(1, "CutBread", "Get knife", "Knife"),
                new Command(2, "Make cup of tea", "Place teabag", "Cup")
        };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command(0, "Boil an egg", "Boil water", "Pan");
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
