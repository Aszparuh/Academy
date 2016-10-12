using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SchoolSystem.Logic.Contracts;

namespace SchoolSystem.Logic
{
    public class Engine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Start()
        {
            while (true)
            {
                try
                {
                    var line = this.reader.ReadLine();
                    if (line == "End")
                    {
                        break;
                    }

                    var commandName = line.Split(' ')[0];
                    var assembly = this.GetType().GetTypeInfo().Assembly;
                    var tpyeinfo = assembly
                        .DefinedTypes
                        .Where(type => type.ImplementedInterfaces
                        .Any(c => c == typeof(ICommand)))
                        .Where(type => type.Name.ToLower()
                        .Contains(commandName.ToLower()))
                        .FirstOrDefault();

                    if (tpyeinfo == null)
                    {
                        throw new ArgumentException("The passed command is not found!");
                    }

                    var command = Activator.CreateInstance(tpyeinfo) as ICommand;
                    var parameters = line.Split(' ').ToList();
                    parameters.RemoveAt(0);
                    var commandResult = command.Execute(parameters);
                    this.writer.WriteLine(commandResult);
                }
                catch (Exception ex)
                {
                    this.writer.WriteLine(ex.Message);
                }
            }
        }
    }
}
